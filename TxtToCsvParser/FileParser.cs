using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace ParserMiamidade
{
    public partial class FileParser : Form
    {
        public const string Headers = "Board, Board Name, Licensee Name, DBA Name, Rank, Address 1, Address 2, Address 3, City, State, Zip, " +
            "County Code, County Name, License Number, Primary Status, Secondary Status, Original License Date, Status Effective Date, " +
            "License Expiration Date, Alternate License Number, Self Proprietor’s Name, Employer’s Name, Employer’s License Number";

        public Dictionary<string, (int, int)> dictionary = new Dictionary<string, (int, int)>();

        public Dictionary<string, string> testDict = new Dictionary<string, string>();


        public FileParser()
        {
            InitializeComponent();
            btnStart.Enabled = false;
            btnReset.Enabled = false;
            rtxtBoxLogs.ScrollBars = RichTextBoxScrollBars.Both;
            prgBarProgress.Style = ProgressBarStyle.Continuous;
        }

        private void ParseCsvFile(string filePath, string outputFolder)
        {
            try
            {
                AppendTextToLogView("Reading file contents....");
                rtxtBoxLogs.Refresh();

                var fileProps = File.ReadLines(filePath);
                var numberOfEntries = fileProps.Count();

                AppendTextToLogView("Total number of records found in .csv file: " + (numberOfEntries - 1));
                AppendTextToLogView("Started parsing file... ");

                var fileName = Path.GetFileName(filePath);
                var totalFiles = CalculateNumberOfFiles(numberOfEntries);
                SetProgressBarProps(numberOfEntries);


                var parsedRecordsToString = new List<List<string>>();

                new Thread(() =>
                {
                    try 
                    {
                        using (var reader = new StreamReader(filePath))
                        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                        {
                            HasHeaderRecord = false,
                            Delimiter = ","
                        }))
                        {
                            int rowCounter = 0;
                            int fileCounter = 1;
                            
                            List<string> headers = new List<string>();

                            foreach (var record in csv.GetRecords<dynamic>())
                            {
                                var rowData = new List<string>();
                                var recordDict = (IDictionary<string, object>)record;

                                foreach (var field in recordDict.Values)
                                {
                                    rowData.Add(field?.ToString());
                                }

                                if (rowCounter == 0)
                                {
                                    headers = new List<string>(rowData);
                                    rowCounter++;
                                    continue;
                                }

                                if (parsedRecordsToString.Count() < fileBreaker.Value)
                                {
                                    // perform parsing here
                                    var parsedData = Parser.ParseListofStrings(rowData);
                                    parsedRecordsToString.Add(rowData);
                                    if (rowCounter == numberOfEntries - 1)
                                    {
                                        // Write to Outputfile
                                        WriteOutput(outputFolder, fileName, parsedRecordsToString, fileCounter, headers);
                                        break;
                                    }
                                }
                                else
                                {
                                    var outputFileList = new List<List<string>>(parsedRecordsToString);
                                    parsedRecordsToString.Clear();
                                    parsedRecordsToString.Add(rowData);
                                    WriteOutput(outputFolder, fileName, outputFileList, fileCounter, headers);
                                    fileCounter++;
                                }

                                prgBarProgress.Invoke(new MethodInvoker(delegate
                                {
                                    prgBarProgress.Value = rowCounter;
                                }));
                                rowCounter++;
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        // log error
                    }

                    AppendTextToLogView("Total number of records processed: " + (numberOfEntries - 1));
                    AppendTextToLogView("File processed successfully.");

                }).Start();

            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while reading the file: {e.Message}");
            }
        }

        private void WriteOutput(string outputFolder, string fileName, List<List<string>> parsedRecordsToString, int fileCounter, List<string> headers)
        {
            var outputPath = Path.Combine(outputFolder, fileName.Replace(".csv", "_" + fileCounter + ".csv"));
            parsedRecordsToString.Insert(0, headers);
            WriteToCsv(parsedRecordsToString, outputPath);
        }

        private void WriteToCsv(List<List<string>> data, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var line in data)
                {
                    // Join each string in the inner list with commas and write to file
                    writer.WriteLine(string.Join(",", line));
                }
            }
        }

        private int WriteOutputFile(string outputFolder, string filename, List<List<string>> lines, int currentLineIndex)
        {
            var outputPath = Path.Combine(outputFolder, filename);
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine(Headers);
                List<string> line;
                int rowCount = 1;

                while (currentLineIndex < lines.Count())
                {
                    line = lines[currentLineIndex];
                    var parcedLineList = Parser.ParseListofStrings(line);

                    var parcedLineToCsv = System.String.Join(",", parcedLineList);
                    writer.WriteLine(parcedLineToCsv);
                    prgBarProgress.Invoke(new MethodInvoker(delegate
                    {
                        prgBarProgress.Value = currentLineIndex;
                    }));

                    if (rowCount == fileBreaker.Value)
                    {
                        return currentLineIndex + 1;
                    }

                    currentLineIndex++;
                    rowCount++;
                }

                return -1;
            }
        }

        private void btnFilePicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select CSV File";
            dlg.InitialDirectory = @"C:\";
            dlg.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.ShowDialog();

            if (!string.IsNullOrEmpty(dlg.FileName))
            {
                if (dlg.FileName.EndsWith(".csv"))
                {
                    txtBoxFilePicker.Text = dlg.FileName;
                    AppendTextToLogView("Uploaded file from \"" + dlg.FileName.ToString() + "\"");
                    EnableStartAndResetButton();
                }
                else
                {
                    MessageBox.Show("Only File with .csv extention can be selected.", "ERROR");
                }
            }
        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                txtboxFileSave.Text = fbd.SelectedPath;
                AppendTextToLogView("File will be saved to the following directory: \"" + fbd.SelectedPath.ToString() + "\"");
                EnableStartAndResetButton();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var inputFilePath = txtBoxFilePicker.Text;
            var outputPath = txtboxFileSave.Text;
            if (!File.Exists(inputFilePath))
            {
                MessageBox.Show("Specified file does not exist.", "Invalid File!");
            }
            else if (!Directory.Exists(outputPath))
            {
                MessageBox.Show("Specified directory does not exist.", "Invalid Directory!");
            }
            else
            {
                ParseCsvFile(inputFilePath, outputPath);
            }
        }

        private void EnableStartAndResetButton()
        {
            if (!string.IsNullOrEmpty(txtboxFileSave.Text) && !string.IsNullOrEmpty(txtBoxFilePicker.Text))
            {
                btnStart.Enabled = true;

            }

            if (!string.IsNullOrEmpty(txtboxFileSave.Text) || !string.IsNullOrEmpty(txtBoxFilePicker.Text))
            {
                btnReset.Enabled = true;
            }
        }

        private void SetProgressBarProps(int Maximum)
        {
            if (prgBarProgress.InvokeRequired)
            {
                prgBarProgress.Invoke(new MethodInvoker(delegate
                {
                    prgBarProgress.Maximum = Maximum;
                    prgBarProgress.Minimum = 0;
                }));
            }
            else
            {
                prgBarProgress.Maximum = Maximum;
                prgBarProgress.Minimum = 0;
            }
        }

        private void txtBoxFilePicker_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxFilePicker.Text))
            {
                var validFilePath = File.Exists(txtBoxFilePicker.Text);
                if (!validFilePath)
                {
                    lblInputErrorMsg.Text = "Enter the valid file path!";
                    lblInputErrorMsg.Visible = true;
                    lblInputErrorMsg.ForeColor = Color.Red;
                }
                else
                {
                    lblInputErrorMsg.Visible = false;
                    EnableStartAndResetButton();
                }
            }
            else { lblInputErrorMsg.Visible = false; }
        }

        private void txtboxFileSave_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtboxFileSave.Text))
            {
                var validDirecToryPath = Directory.Exists(txtboxFileSave.Text);
                if (!validDirecToryPath)
                {
                    lblOutputErrorMsg.Text = "Enter the valid directory path!";
                    lblOutputErrorMsg.Visible = true;
                    lblOutputErrorMsg.ForeColor = Color.Red;
                }
                else
                {
                    lblOutputErrorMsg.Visible = false;
                    EnableStartAndResetButton();
                }
            }
            else { lblOutputErrorMsg.Visible = false; }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxFilePicker.Text = string.Empty;
            txtboxFileSave.Text = string.Empty;
            rtxtBoxLogs.Text = string.Empty;
            prgBarProgress.Value = 0;
            btnStart.Enabled = false;
            btnReset.Enabled = false;
        }

        private void AppendTextToLogView(string log)
        {
            if (rtxtBoxLogs.InvokeRequired)
            {
                rtxtBoxLogs.Invoke(new MethodInvoker(delegate { rtxtBoxLogs.Text += log + Environment.NewLine; }));
            }
            else
            {
                rtxtBoxLogs.Text += log + Environment.NewLine;
            }
        }

        private int CalculateNumberOfFiles(int lines)
        {
            int totalFiles;
            if (fileBreaker.Value > 0)
            {
                totalFiles = (lines / (int)fileBreaker.Value) + 1;
            }
            else
            {
                totalFiles = 1;
            }

            return totalFiles;
        }
    }
}
