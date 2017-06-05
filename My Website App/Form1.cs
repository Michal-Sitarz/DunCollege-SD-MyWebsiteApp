using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Website_App
{
    public partial class Form1 : Form
    {
        // global variables(strings)
        public string name = "";
        public string description = "";
        public string bgColor = "";
        // end of: global variables



    // initialize webform
    public Form1()
        {
            InitializeComponent();
            List<string> items = new List<string>()
                {"black", "white", "grey", "blue", "red"};
            fontColourBox.DataSource = items;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // name box
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            name = nameBox.Text;
        }

        // description box
        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            description = descriptionBox.Text;
        }

       
        // font colour box
        private void fontColourBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                            
        }

        // background colour box
        private void bgColourButton_Click(object sender, EventArgs e)
        {
            bgColorBox.ShowDialog();
            bgColourButton.BackColor = bgColorBox.Color;

        //converting color from: system dialog box 
        //             >>> into: hex style string
            Color clr = bgColorBox.Color;
            bgColor = String.Format("{0:X2}{1:X2}{2:X2}", clr.R, clr.G, clr.B);
            
        }


        // 
        // "Create" button
        // gathers information and generates the website
        private void createButton_Click(object sender, EventArgs e)
        {
            //
            // checking chosen font colour
            string fontColour;
            switch (fontColourBox.SelectedIndex)
            {
                case 0:
                    fontColour = "black";
                    break;
                case 1:
                    fontColour = "white";
                    break;
                case 2:
                    fontColour = "grey";
                    break;
                case 3:
                    fontColour = "darkblue";
                    break;
                case 4:
                    fontColour = "red";
                    break;
                default:
                    fontColour = "black";
                    break;
            }


            //
            //building html code
            string html = generateHTML(fontColour);


            //
            // file-handling:
                // > save the file on the HDD
            System.IO.File.WriteAllText(@"C:\Users\Public\Downloads\index.html", html);
            
                // > open created file in default web browser
            System.Diagnostics.Process.Start(@"C:\Users\Public\Downloads\index.html");
        }


        // method to generate html code 
        // (run by "Create" button only, in v1.0 of the app)
        private string generateHTML(string fontColour)
        {


            // building <style> section of the webpage
            string style = "body{width:50%; position:absolute; top:50%; left:50%; transform:translate(-50%, -50%);"
                         + "font-family: 'Comic Sans MS', cursive, sans-serif;"
                         + "background-color:" + bgColor + ";"
                         + "color:" + fontColour + "}";


            // building content of the webpage
            string content = "<h1>Hi, my name is " + name + "</h1>"
                           + "<h3>Welcome on my first website! :)</h3>"
                           + "<p>" + description + "</p>";


            // building full html chain
            string full_html = "<html><head><title>"
                               + name
                               + "</title><style>"
                               + style
                               + "</style></head><body>"
                               + content
                               + "</body></html>";

            return full_html;
        }


    }
}
