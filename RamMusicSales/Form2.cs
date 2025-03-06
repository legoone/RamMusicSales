using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace RamMusicSales
{
    public partial class Form2 : Form
    {

        private Form1 ff;
        public Form2(Form1 form1)
        {
            ff = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hiphopValid, rockValid, popValid, jazzValid, technoValid, countryValid;
            double hhTempValue, rTempValue, pTempValue, jTempValue, tTempValue, cTempValue;

            StreamWriter sw;

            
            hiphopValid = double.TryParse(txtHipHop.Text, out hhTempValue);
            rockValid = double.TryParse(txtRock.Text, out rTempValue);
            popValid = double.TryParse(txtPop.Text, out pTempValue);
            jazzValid = double.TryParse(txtJazz.Text, out jTempValue);
            technoValid = double.TryParse(txtTechno.Text, out tTempValue);
            countryValid = double.TryParse(txtCountry.Text, out cTempValue);

            // check values
            if (hiphopValid && rockValid && popValid && jazzValid && technoValid && countryValid)
            {
                // if values good
                // set properties
                
                
                ff.HipHop = hhTempValue;
                ff.Rock = rTempValue;
                ff.Pop = pTempValue;
                ff.Jazz = jTempValue;
                ff.Techno = tTempValue;
                ff.Country = cTempValue;


                // save values in file
                sw = File.CreateText(ff.MusicConfig);
                
                sw.WriteLine(ff.HipHop);
                sw.WriteLine(ff.Rock);
                sw.WriteLine(ff.Pop);
                sw.WriteLine(ff.Jazz);
                sw.WriteLine(ff.Techno);
                sw.WriteLine(ff.Country);

                sw.Close();

                this.Hide();

            }
            else
            { ff.setValuesOnSecondForm(); }

        }
    }
}
