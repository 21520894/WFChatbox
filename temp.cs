using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeProject_B1
{
    public partial class temp : Form
    {
        private FlowLayoutPanel flowLayoutPanel;
        private TextBox searchTextBox;
        private Button searchButton;

        public temp()
        {
            InitializeComponents();
            LoadMessengerTexts();
        }

        private void InitializeComponents()
        {
            // Create FlowLayoutPanel
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;

            // Create TextBox for search query
            searchTextBox = new TextBox();
            searchTextBox.Width = 200;

            // Create Button for search action
            searchButton = new Button();
            searchButton.Text = "Search";
            searchButton.Click += SearchButton_Click;

            // Create a new TableLayoutPanel to hold search components
            TableLayoutPanel searchPanel = new TableLayoutPanel();
            searchPanel.AutoSize = true;
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            // Add search components to searchPanel
            searchPanel.Controls.Add(searchTextBox, 0, 0);
            searchPanel.Controls.Add(searchButton, 1, 0);

            // Create a new TableLayoutPanel to hold all components
            TableLayoutPanel mainPanel = new TableLayoutPanel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            // Add searchPanel and flowLayoutPanel to mainPanel
            mainPanel.Controls.Add(searchPanel, 0, 0);
            mainPanel.Controls.Add(flowLayoutPanel, 0, 1);

            // Set mainPanel as the form's main control
            Controls.Add(mainPanel);
        }

        private void LoadMessengerTexts()
        {
            // Simulated list of messenger texts
            List<string> messengerTexts = new List<string>
        {
            "Hello, how are you?",
            "I'm doing great!",
            "What's new?",
            "Let's meet up for lunch.",
            "Sure, where should we go?",
            "How about that new restaurant downtown?",
            "Sounds good. See you there!"
        };

            // Add labels for each messenger text to the FlowLayoutPanel
            foreach (string text in messengerTexts)
            {
                Label label = new Label();
                label.Text = text;
                label.AutoSize = true;
                label.Margin = new Padding(5);
                label.Tag = text; // Store the original text in the Tag property

                flowLayoutPanel.Controls.Add(label);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text.ToLower();

            // Loop through each label in the FlowLayoutPanel and update the text to highlight the matching part
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is Label label)
                {
                    string labelText = label.Tag.ToString().ToLower();
                    int startIndex = labelText.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase);

                    if (startIndex >= 0)
                    {
                        string highlightedText = $"<b>{label.Text.Substring(startIndex, searchQuery.Length)}</b>";
                        string newText = label.Tag.ToString().Replace(labelText.Substring(startIndex, searchQuery.Length), highlightedText);

                        // Update the label's text with the highlighted version
                        label.Text = newText;

                        // Scroll the FlowLayoutPanel to the location of the matching label
                        flowLayoutPanel.ScrollControlIntoView(label);
                    }
                }
            }
        }
    }
}
