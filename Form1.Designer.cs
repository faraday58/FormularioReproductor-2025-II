namespace FormularioReproductor_2025_II
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstbRepro = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbArtist = new Label();
            lbTitle = new Label();
            lbAlbum = new Label();
            ptbAlbum = new PictureBox();
            lbTimeStart = new Label();
            lbTimeStop = new Label();
            label6 = new Label();
            prbarTime = new ProgressBar();
            toolStrip1 = new ToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            agregarCanciónToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton2 = new ToolStripSplitButton();
            reproducirToolStripMenuItem = new ToolStripMenuItem();
            pausarToolStripMenuItem = new ToolStripMenuItem();
            detenerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            siguienteToolStripMenuItem = new ToolStripMenuItem();
            anteriorToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ptbAlbum).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstbRepro
            // 
            lstbRepro.FormattingEnabled = true;
            lstbRepro.Location = new Point(52, 85);
            lstbRepro.Name = "lstbRepro";
            lstbRepro.Size = new Size(295, 504);
            lstbRepro.TabIndex = 0;
            lstbRepro.SelectedIndexChanged += lstbRepro_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 178);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Artista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 253);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Título";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 332);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 1;
            label3.Text = "Album";
            // 
            // lbArtist
            // 
            lbArtist.AutoSize = true;
            lbArtist.Location = new Point(649, 178);
            lbArtist.Name = "lbArtist";
            lbArtist.Size = new Size(63, 25);
            lbArtist.TabIndex = 1;
            lbArtist.Text = "Artista";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(649, 253);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(56, 25);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Título";
            // 
            // lbAlbum
            // 
            lbAlbum.AutoSize = true;
            lbAlbum.Location = new Point(649, 332);
            lbAlbum.Name = "lbAlbum";
            lbAlbum.Size = new Size(65, 25);
            lbAlbum.TabIndex = 1;
            lbAlbum.Text = "Album";
            // 
            // ptbAlbum
            // 
            ptbAlbum.Location = new Point(1177, 85);
            ptbAlbum.Name = "ptbAlbum";
            ptbAlbum.Size = new Size(369, 364);
            ptbAlbum.TabIndex = 2;
            ptbAlbum.TabStop = false;
            // 
            // lbTimeStart
            // 
            lbTimeStart.AutoSize = true;
            lbTimeStart.Location = new Point(514, 550);
            lbTimeStart.Name = "lbTimeStart";
            lbTimeStart.Size = new Size(22, 25);
            lbTimeStart.TabIndex = 1;
            lbTimeStart.Text = "0";
            // 
            // lbTimeStop
            // 
            lbTimeStop.AutoSize = true;
            lbTimeStop.Location = new Point(1130, 550);
            lbTimeStop.Name = "lbTimeStop";
            lbTimeStop.Size = new Size(51, 25);
            lbTimeStop.TabIndex = 1;
            lbTimeStop.Text = "2:20 ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(912, 657);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 3;
            // 
            // prbarTime
            // 
            prbarTime.Location = new Point(557, 557);
            prbarTime.Maximum = 140;
            prbarTime.Name = "prbarTime";
            prbarTime.Size = new Size(547, 10);
            prbarTime.Step = 1;
            prbarTime.TabIndex = 4;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripSplitButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1608, 33);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, toolStripMenuItem2, agregarCanciónToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(45, 28);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(246, 34);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(246, 34);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(243, 6);
            // 
            // agregarCanciónToolStripMenuItem
            // 
            agregarCanciónToolStripMenuItem.Name = "agregarCanciónToolStripMenuItem";
            agregarCanciónToolStripMenuItem.Size = new Size(246, 34);
            agregarCanciónToolStripMenuItem.Text = "Agregar Canción";
            agregarCanciónToolStripMenuItem.Click += agregarCanciónToolStripMenuItem_Click;
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton2.DropDownItems.AddRange(new ToolStripItem[] { reproducirToolStripMenuItem, pausarToolStripMenuItem, detenerToolStripMenuItem, toolStripMenuItem1, siguienteToolStripMenuItem, anteriorToolStripMenuItem });
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(45, 28);
            toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // reproducirToolStripMenuItem
            // 
            reproducirToolStripMenuItem.Image = (Image)resources.GetObject("reproducirToolStripMenuItem.Image");
            reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            reproducirToolStripMenuItem.Size = new Size(270, 34);
            reproducirToolStripMenuItem.Text = "Reproducir";
            reproducirToolStripMenuItem.Click += reproducirToolStripMenuItem_Click;
            // 
            // pausarToolStripMenuItem
            // 
            pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            pausarToolStripMenuItem.Size = new Size(270, 34);
            pausarToolStripMenuItem.Text = "Pausar";
            pausarToolStripMenuItem.Click += pausarToolStripMenuItem_Click;
            // 
            // detenerToolStripMenuItem
            // 
            detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            detenerToolStripMenuItem.Size = new Size(270, 34);
            detenerToolStripMenuItem.Text = "Detener";
            detenerToolStripMenuItem.Click += detenerToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(267, 6);
            // 
            // siguienteToolStripMenuItem
            // 
            siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            siguienteToolStripMenuItem.Size = new Size(270, 34);
            siguienteToolStripMenuItem.Text = "Siguiente";
            // 
            // anteriorToolStripMenuItem
            // 
            anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            anteriorToolStripMenuItem.Size = new Size(270, 34);
            anteriorToolStripMenuItem.Text = "Anterior";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 801);
            Controls.Add(toolStrip1);
            Controls.Add(prbarTime);
            Controls.Add(label6);
            Controls.Add(ptbAlbum);
            Controls.Add(lbAlbum);
            Controls.Add(lbTimeStop);
            Controls.Add(lbTimeStart);
            Controls.Add(label3);
            Controls.Add(lbTitle);
            Controls.Add(label2);
            Controls.Add(lbArtist);
            Controls.Add(label1);
            Controls.Add(lstbRepro);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptbAlbum).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbRepro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbArtist;
        private Label lbTitle;
        private Label lbAlbum;
        private PictureBox ptbAlbum;
        private Label lbTimeStart;
        private Label lbTimeStop;
        private Label label6;
        private ProgressBar prbarTime;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripMenuItem reproducirToolStripMenuItem;
        private ToolStripMenuItem pausarToolStripMenuItem;
        private ToolStripMenuItem detenerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem siguienteToolStripMenuItem;
        private ToolStripMenuItem anteriorToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem agregarCanciónToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}
