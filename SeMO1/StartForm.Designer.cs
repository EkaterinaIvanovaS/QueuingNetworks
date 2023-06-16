
namespace SeMO1
{
    partial class StartForm
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
            this.createGrid = new System.Windows.Forms.Button();
            this.nameStartForm = new System.Windows.Forms.Label();
            this.countSystem = new System.Windows.Forms.Label();
            this.countRequirement = new System.Windows.Forms.Label();
            this.theoremNumber = new System.Windows.Forms.Label();
            this.theorem1 = new System.Windows.Forms.Button();
            this.theorem2 = new System.Windows.Forms.Button();
            this.theorem3 = new System.Windows.Forms.Button();
            this.countSystems = new System.Windows.Forms.NumericUpDown();
            this.countRequirements = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.countSystems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRequirements)).BeginInit();
            this.SuspendLayout();
            // 
            // createGrid
            // 
            this.createGrid.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGrid.Location = new System.Drawing.Point(303, 317);
            this.createGrid.Name = "createGrid";
            this.createGrid.Size = new System.Drawing.Size(224, 61);
            this.createGrid.TabIndex = 0;
            this.createGrid.Text = "Create Grid";
            this.createGrid.UseVisualStyleBackColor = true;
            this.createGrid.Click += new System.EventHandler(this.createGrid_Click);
            // 
            // nameStartForm
            // 
            this.nameStartForm.AutoSize = true;
            this.nameStartForm.Font = new System.Drawing.Font("Source Serif Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameStartForm.Location = new System.Drawing.Point(60, 40);
            this.nameStartForm.Name = "nameStartForm";
            this.nameStartForm.Size = new System.Drawing.Size(681, 38);
            this.nameStartForm.TabIndex = 1;
            this.nameStartForm.Text = "Calculating the characteristics of queuing networks";
            // 
            // countSystem
            // 
            this.countSystem.AutoSize = true;
            this.countSystem.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countSystem.Location = new System.Drawing.Point(83, 116);
            this.countSystem.Name = "countSystem";
            this.countSystem.Size = new System.Drawing.Size(181, 23);
            this.countSystem.TabIndex = 2;
            this.countSystem.Text = "Count of systems";
            // 
            // countRequirement
            // 
            this.countRequirement.AutoSize = true;
            this.countRequirement.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countRequirement.Location = new System.Drawing.Point(83, 181);
            this.countRequirement.Name = "countRequirement";
            this.countRequirement.Size = new System.Drawing.Size(235, 23);
            this.countRequirement.TabIndex = 3;
            this.countRequirement.Text = "Count of requirements";
            // 
            // theoremNumber
            // 
            this.theoremNumber.AutoSize = true;
            this.theoremNumber.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theoremNumber.Location = new System.Drawing.Point(83, 246);
            this.theoremNumber.Name = "theoremNumber";
            this.theoremNumber.Size = new System.Drawing.Size(180, 23);
            this.theoremNumber.TabIndex = 4;
            this.theoremNumber.Text = "Theorem number";
            // 
            // theorem1
            // 
            this.theorem1.Location = new System.Drawing.Point(334, 242);
            this.theorem1.Name = "theorem1";
            this.theorem1.Size = new System.Drawing.Size(100, 35);
            this.theorem1.TabIndex = 5;
            this.theorem1.Text = "theorem 1";
            this.theorem1.UseVisualStyleBackColor = true;
            this.theorem1.Click += new System.EventHandler(this.theorem1_Click);
            // 
            // theorem2
            // 
            this.theorem2.Location = new System.Drawing.Point(477, 243);
            this.theorem2.Name = "theorem2";
            this.theorem2.Size = new System.Drawing.Size(100, 33);
            this.theorem2.TabIndex = 6;
            this.theorem2.Text = "theorem 2";
            this.theorem2.UseVisualStyleBackColor = true;
            this.theorem2.Click += new System.EventHandler(this.theorem2_Click);
            // 
            // theorem3
            // 
            this.theorem3.Location = new System.Drawing.Point(610, 243);
            this.theorem3.Name = "theorem3";
            this.theorem3.Size = new System.Drawing.Size(100, 32);
            this.theorem3.TabIndex = 7;
            this.theorem3.Text = "theorem 3";
            this.theorem3.UseVisualStyleBackColor = true;
            this.theorem3.Click += new System.EventHandler(this.theorem3_Click);
            // 
            // countSystems
            // 
            this.countSystems.Location = new System.Drawing.Point(334, 113);
            this.countSystems.Name = "countSystems";
            this.countSystems.Size = new System.Drawing.Size(120, 26);
            this.countSystems.TabIndex = 10;
            // 
            // countRequirements
            // 
            this.countRequirements.Location = new System.Drawing.Point(334, 178);
            this.countRequirements.Name = "countRequirements";
            this.countRequirements.Size = new System.Drawing.Size(120, 26);
            this.countRequirements.TabIndex = 11;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countRequirements);
            this.Controls.Add(this.countSystems);
            this.Controls.Add(this.theorem3);
            this.Controls.Add(this.theorem2);
            this.Controls.Add(this.theorem1);
            this.Controls.Add(this.theoremNumber);
            this.Controls.Add(this.countRequirement);
            this.Controls.Add(this.countSystem);
            this.Controls.Add(this.nameStartForm);
            this.Controls.Add(this.createGrid);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.countSystems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRequirements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createGrid;
        private System.Windows.Forms.Label nameStartForm;
        private System.Windows.Forms.Label countSystem;
        private System.Windows.Forms.Label countRequirement;
        private System.Windows.Forms.Label theoremNumber;
        private System.Windows.Forms.Button theorem1;
        private System.Windows.Forms.Button theorem2;
        private System.Windows.Forms.Button theorem3;
        private System.Windows.Forms.NumericUpDown countSystems;
        private System.Windows.Forms.NumericUpDown countRequirements;
    }
}