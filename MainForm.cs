using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace cs_cipher {
    public partial class MainForm : Form {
        // This is the output textbox
        public object Result {
            get => txtbxoutput.Text;
            set => txtbxoutput.Text = value.ToString();
        }

        // This is the input textbox
        public object Input {
            get => txtbxinput.Text;
            set => txtbxinput.Text = value.ToString();
        }
        
        public IEnumerable<IAlgorithm> Algorithms { get; set; }
        public string SelectedAlgorithm { get; set; } // This is the selected algorithm

        // This is the constructor
        public MainForm() {
            InitializeComponent();
            // This is the list of algorithms
            Algorithms = new IAlgorithm[] {
                new CezarAlgorithm(),
                new AtBashAlgorithm(),
                new Rot13Algorithm(),
            };
            object[] algorithmNames = Algorithms.Select(a => a.Name).ToArray(); // This is the list of algorithm names
            lstbxalgorithm.Items.AddRange(algorithmNames); // This adds the algorithm names to the listbox
        }
        private void MainForm_Load(object sender, EventArgs e) {
        }


        // This is the listbox that changes the selected algorithm
        private void lstbxalgorithm_SelectedIndexChanged(object sender, EventArgs e) {
            SelectedAlgorithm = lstbxalgorithm.SelectedItem.ToString();
            // Default Hide
            numcezar.Visible = false;
            
            // Show the settings for the selected algorithm
            foreach (IAlgorithm algorithm in Algorithms) {
                if (algorithm.Name == "Cäsar" && algorithm.Name == SelectedAlgorithm) {
                    // Show the numeric up down for the Cezar algorithm
                    numcezar.Visible = true;
                    CezarAlgorithm cezar = (CezarAlgorithm)algorithm;
                    cezar.Offset = (int)numcezar.Value;
                }
            }
        }
        
        // This is the numeric up down that changes the offset for the Cezar algorithm
        private void numcezar_ValueChanged(object sender, EventArgs e) {
            foreach (IAlgorithm algorithm in Algorithms) {
                if (algorithm.Name == "Cäsar" && algorithm.Name == SelectedAlgorithm) {
                    // Set the offset for the Cezar algorithm
                    CezarAlgorithm cezar = (CezarAlgorithm)algorithm;
                    cezar.Offset = (int)numcezar.Value;
                }
            }
        }
        
        // This is the button that runs the algorithm
        private void btnencrypt_Click(object sender, EventArgs e) {
            // Check if the input is null or the algorithm is null
            if (Input == null || lstbxalgorithm.SelectedItem == null) {
                return;
            }
            // Get the selected algorithm
            SelectedAlgorithm = lstbxalgorithm.SelectedItem.ToString();
            foreach (IAlgorithm algorithm in Algorithms) {
                if (algorithm.Name == SelectedAlgorithm) {
                    // Run the algorithm
                    Result = algorithm.To(Input.ToString());
                }
            }
        }


        private void btndecrypt_Click(object sender, EventArgs e) {
            // Check if the input is null or the algorithm is null
            if (Result == null) {
                return;
            }
            // Get the selected algorithm
            SelectedAlgorithm = lstbxalgorithm.SelectedItem.ToString();
            foreach (IAlgorithm algorithm in Algorithms) {
                if (algorithm.Name == SelectedAlgorithm) {
                    // Run the algorithm backwards
                    Input = algorithm.From(Result.ToString());
                }
            }
        }

        private string FileInput() {
            // This is the file input dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                // Return the file content
                return File.ReadAllText(openFileDialog.FileName);
            }
            return "";
        }
        
        private string FileOutput(string text) {
            // This is the file output dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                // Write the file content
                File.WriteAllText(saveFileDialog.FileName, text);
                return saveFileDialog.FileName;
            }
            return "";
        }
        

        private void openfilein_Click(object sender, EventArgs e) {
            // This is the button that opens the file input dialog
            txtbxinput.Text = FileInput();
        }

        private void filewritein_Click(object sender, EventArgs e) {
            // This is the button that opens the file save dialog
            FileOutput(txtbxinput.Text);
        }

        private void openfileout_Click(object sender, EventArgs e) {
            // This is the button that opens the file input dialog
            txtbxoutput.Text = FileInput();
        }

        private void writefileout_Click(object sender, EventArgs e) {
            // This is the button that opens the file save dialog
            FileOutput(txtbxoutput.Text);
        }
    }
}