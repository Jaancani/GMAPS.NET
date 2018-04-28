namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.Map1 = new GMap.NET.WindowsForms.GMapControl();
            this.Longitud = new System.Windows.Forms.Label();
            this.txtLongi = new System.Windows.Forms.TextBox();
            this.txtLati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(0, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(612, 490);
            this.splitter3.TabIndex = 0;
            this.splitter3.TabStop = false;
            // 
            // Map1
            // 
            this.Map1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Map1.Bearing = 0F;
            this.Map1.CanDragMap = true;
            this.Map1.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map1.GrayScaleMode = false;
            this.Map1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map1.LevelsKeepInMemmory = 5;
            this.Map1.Location = new System.Drawing.Point(13, 13);
            this.Map1.MarkersEnabled = true;
            this.Map1.MaxZoom = 2;
            this.Map1.MinZoom = 2;
            this.Map1.MouseWheelZoomEnabled = true;
            this.Map1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map1.Name = "Map1";
            this.Map1.NegativeMode = false;
            this.Map1.PolygonsEnabled = true;
            this.Map1.RetryLoadTile = 0;
            this.Map1.RoutesEnabled = true;
            this.Map1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map1.ShowTileGridLines = false;
            this.Map1.Size = new System.Drawing.Size(580, 465);
            this.Map1.TabIndex = 1;
            this.Map1.Zoom = 0D;
            // 
            // Longitud
            // 
            this.Longitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(629, 158);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(48, 13);
            this.Longitud.TabIndex = 2;
            this.Longitud.Text = "Longitud";
            // 
            // txtLongi
            // 
            this.txtLongi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLongi.Location = new System.Drawing.Point(684, 155);
            this.txtLongi.Name = "txtLongi";
            this.txtLongi.Size = new System.Drawing.Size(100, 20);
            this.txtLongi.TabIndex = 3;
            // 
            // txtLati
            // 
            this.txtLati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLati.Location = new System.Drawing.Point(684, 198);
            this.txtLati.Name = "txtLati";
            this.txtLati.Size = new System.Drawing.Size(100, 20);
            this.txtLati.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latitud";
            // 
            // GO
            // 
            this.GO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GO.Cursor = System.Windows.Forms.Cursors.No;
            this.GO.Location = new System.Drawing.Point(641, 274);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(143, 23);
            this.GO.TabIndex = 6;
            this.GO.Text = "GO ON MAP";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(814, 490);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.txtLati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLongi);
            this.Controls.Add(this.Longitud);
            this.Controls.Add(this.Map1);
            this.Controls.Add(this.splitter3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTlat;
        private System.Windows.Forms.TextBox TXTlon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadMAP;
        private System.Windows.Forms.Splitter splitter2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Splitter splitter3;
        private GMap.NET.WindowsForms.GMapControl Map1;
        private System.Windows.Forms.Label Longitud;
        private System.Windows.Forms.TextBox txtLongi;
        private System.Windows.Forms.TextBox txtLati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GO;
    }
}

