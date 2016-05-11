namespace WindowsFormsApplication1
{
    
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.figuraToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // figuraToolStripMenuItem
            // 
            this.figuraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectanguloToolStripMenuItem,
            this.circuloToolStripMenuItem});
            this.figuraToolStripMenuItem.Name = "figuraToolStripMenuItem";
            this.figuraToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.figuraToolStripMenuItem.Text = "Figura";
            this.figuraToolStripMenuItem.Click += new System.EventHandler(this.figuraToolStripMenuItem_Click);
            // 
            // rectanguloToolStripMenuItem
            // 
            this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.rectanguloToolStripMenuItem.Text = "Rectangulo";
            this.rectanguloToolStripMenuItem.Click += new System.EventHandler(this.rectanguloToolStripMenuItem_Click);
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.circuloToolStripMenuItem.Text = "Circulo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(511, 311);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
    }
}
