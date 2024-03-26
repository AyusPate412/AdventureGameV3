namespace AdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option3Label = new System.Windows.Forms.Label();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.PictureBox();
            this.titleImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(76, 12);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(630, 76);
            this.outputLabel.TabIndex = 3;
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(465, 528);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(287, 29);
            this.option1Label.TabIndex = 4;
            this.option1Label.Text = "label1";
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(466, 493);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(287, 31);
            this.option2Label.TabIndex = 5;
            this.option2Label.Text = "label1";
            // 
            // option1Button
            // 
            this.option1Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option1Button.BackgroundImage")));
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1Button.Location = new System.Drawing.Point(116, 525);
            this.option1Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(65, 31);
            this.option1Button.TabIndex = 6;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option2Button.BackgroundImage")));
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option2Button.CausesValidation = false;
            this.option2Button.Location = new System.Drawing.Point(116, 492);
            this.option2Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(65, 29);
            this.option2Button.TabIndex = 7;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("option3Button.BackgroundImage")));
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option3Button.Location = new System.Drawing.Point(116, 560);
            this.option3Button.Margin = new System.Windows.Forms.Padding(2);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(65, 31);
            this.option3Button.TabIndex = 10;
            this.option3Button.UseVisualStyleBackColor = true;
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(465, 557);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(287, 29);
            this.option3Label.TabIndex = 11;
            this.option3Label.Text = "label1";
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Image = global::AdventureGame.Properties.Resources.Designer;
            this.mainPictureBox.Location = new System.Drawing.Point(12, 91);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(470, 380);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 9;
            this.mainPictureBox.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.Location = new System.Drawing.Point(598, 271);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(120, 51);
            this.playButton.TabIndex = 2;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleLabel.BackgroundImage")));
            this.titleLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.titleLabel.Location = new System.Drawing.Point(116, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(602, 56);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.TabStop = false;
            // 
            // titleImage
            // 
            this.titleImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleImage.BackgroundImage")));
            this.titleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleImage.Location = new System.Drawing.Point(12, 91);
            this.titleImage.Name = "titleImage";
            this.titleImage.Size = new System.Drawing.Size(461, 540);
            this.titleImage.TabIndex = 0;
            this.titleImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(764, 609);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox titleImage;
        private System.Windows.Forms.PictureBox titleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option3Label;
    }
}

