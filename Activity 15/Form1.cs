using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class form_LuckyNumbers : Form
    {
        public form_LuckyNumbers()
        {
            InitializeComponent();
        }

        // Hold lucky number
        public static int luckyNumber;

        // Convert month name to number
        public int GetMonthNumber(string monthString)
        {
            int monthInt = 0;
            switch (monthString)
            {
                case "January":
                    monthInt = 1;
                    break;
                case "February":
                    monthInt = 2;
                    break;
                case "March":
                    monthInt = 3;
                    break;
                case "April":
                    monthInt = 4;
                    break;
                case "May":
                    monthInt = 5;
                    break;
                case "June":
                    monthInt = 6;
                    break;
                case "July":
                    monthInt = 7;
                    break;
                case "August":
                    monthInt = 8;
                    break;
                case "September":
                    monthInt = 9;
                    break;
                case "October":
                    monthInt = 10;
                    break;
                case "November":
                    monthInt = 11;
                    break;
                case "December":
                    monthInt = 12;
                    break;
            }
            return monthInt;
        }

        // Convert color to number
        public int GetColorNumber(string colorString)
        {
            int colorInt = 0;
            switch (colorString)
            {
                case "Red":
                    colorInt = 2;
                    break;
                case "Green":
                    colorInt = 3;
                    break;
                case "Blue":
                    colorInt = 4;
                    break;
                case "Yellow":
                    colorInt = 5;
                    break;
                case "Orange":
                    colorInt = 6;
                    break;
                case "Purple":
                    colorInt = 7;
                    break;
            }
            return colorInt;
        }

        public int CalculateLuckyNumber()
        {
            int year = int.Parse(cmBxYear.Text);
            int month = GetMonthNumber(cmBxMonth.Text);
            int day = int.Parse(cmBxDay.Text);
            int color = GetColorNumber(cmBxColor.Text);

            return year / (month + day + color);
        }

        public void form_LuckyNumbers_Load(object sender, EventArgs e)
        {
            // Add years to cmBxYear
            for (int i = 2022; i >= 1922; i--)
            {
                cmBxYear.Items.Add(i.ToString());
            }

            // Add months to cmBxMonth
            string[] monthArray = { "January", "February", "March", "April", "May", "June", 
                                    "July", "August", "September", "October", "November", "December" };
            cmBxMonth.Items.AddRange(monthArray);

            // Add colors to cmBxColor
            string[] colorArray = { "Red", "Blue", "Green", "Yellow", "Orange", "Purple" };
            cmBxColor.Items.AddRange(colorArray);

            cmBxMonth.SelectedIndexChanged += new System.EventHandler(cmBxMonth_SelectedIndexChanged);
            
        }

        public void cmBxMonth_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cmBxDay.Items.Clear();

            ComboBox comboBox = (ComboBox) sender;

            string selectedMonth = (string)comboBox.SelectedItem;
            
            // Get days in month based on user selection
            int days = DateTime.DaysInMonth(2022, GetMonthNumber(selectedMonth));

            // Add days to ComboBox
            for (int i = 1; i <= days; i++)
            {
                cmBxDay.Items.Add(i);
            }

        }

        public void btn_submit_Click(object sender, EventArgs e)
        {
            // Input validation
            if (cmBxYear.Text == "" || cmBxMonth.Text == "" || cmBxDay.Text == "" || cmBxColor.Text == "")
            {
                MessageBox.Show("Please fill out every form");
            }
            else
            {
                // Hide Current form and display Results form
                this.Hide();

                luckyNumber = CalculateLuckyNumber();

                form_results form_Results = new form_results();
                

                form_Results.ShowDialog();
                

                // When results form is closed, show LuckyNumbers form
                form_Results = null;

                this.Show();
            }
            
        }
    }
}
