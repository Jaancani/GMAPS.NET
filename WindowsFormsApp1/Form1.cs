using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GO_Click(object sender, EventArgs e)
        {
            Map1.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtLati.Text);
            double longi = Convert.ToDouble(txtLongi.Text);
            Map1.Position = new PointLatLng(lat, longi);
        }
    }
}
