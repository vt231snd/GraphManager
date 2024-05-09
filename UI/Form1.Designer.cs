﻿namespace UI
{
    partial class Field
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddVertex = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddEdge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Linen;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 635);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // buttonAddVertex
            // 
            this.buttonAddVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddVertex.Location = new System.Drawing.Point(1039, 183);
            this.buttonAddVertex.Name = "buttonAddVertex";
            this.buttonAddVertex.Size = new System.Drawing.Size(222, 65);
            this.buttonAddVertex.TabIndex = 1;
            this.buttonAddVertex.Text = "Add Vertex";
            this.buttonAddVertex.UseVisualStyleBackColor = true;
            this.buttonAddVertex.Click += new System.EventHandler(this.buttonAddVertex_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.Location = new System.Drawing.Point(1039, 378);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(222, 65);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(1039, 286);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(222, 65);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddEdge
            // 
            this.buttonAddEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddEdge.Location = new System.Drawing.Point(1039, 472);
            this.buttonAddEdge.Name = "buttonAddEdge";
            this.buttonAddEdge.Size = new System.Drawing.Size(222, 65);
            this.buttonAddEdge.TabIndex = 4;
            this.buttonAddEdge.Text = "Add Edge";
            this.buttonAddEdge.UseVisualStyleBackColor = true;
            this.buttonAddEdge.Click += new System.EventHandler(this.buttonAddEdge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1032, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Num of edge";
            // 
            // Field
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1302, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddEdge);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonAddVertex);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Field";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "курсач";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Field_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Field_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddVertex;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddEdge;
        private System.Windows.Forms.Label label1;
    }
}

