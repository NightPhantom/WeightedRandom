namespace WeightedRandomDemoWindowsForms
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
            groupBoxIterations = new GroupBox();
            rollCountD = new ProgressBar();
            weightD = new TrackBar();
            optionD = new TextBox();
            rollCountC = new ProgressBar();
            weightC = new TrackBar();
            optionC = new TextBox();
            rollCountB = new ProgressBar();
            weightB = new TrackBar();
            optionB = new TextBox();
            rollCountA = new ProgressBar();
            weightA = new TrackBar();
            optionA = new TextBox();
            labelRollCountTitle = new Label();
            labelIterationWeightsTitle = new Label();
            labelIterationOptionsTitle = new Label();
            trackBarIterations = new TrackBar();
            textBoxIterationCount = new TextBox();
            labelIterationCountLabel = new Label();
            buttonRunIterations = new Button();
            groupBoxImages = new GroupBox();
            resultImage = new PictureBox();
            imageWeight4 = new TrackBar();
            picture4 = new PictureBox();
            imageWeight3 = new TrackBar();
            picture3 = new PictureBox();
            imageWeight2 = new TrackBar();
            picture2 = new PictureBox();
            imageWeight1 = new TrackBar();
            labelImageWeightsTitle = new Label();
            labelImageOptionsTitle = new Label();
            picture1 = new PictureBox();
            buttonGetImage = new Button();
            groupBoxStrings = new GroupBox();
            labelWordWeightsTitle = new Label();
            labelWordOptionsTitle = new Label();
            buttonGetWord = new Button();
            word1 = new TextBox();
            word2 = new TextBox();
            word3 = new TextBox();
            word4 = new TextBox();
            word5 = new TextBox();
            wordWeight1 = new TrackBar();
            wordWeight2 = new TrackBar();
            wordWeight3 = new TrackBar();
            wordWeight4 = new TrackBar();
            wordWeight5 = new TrackBar();
            labelWordResultTitle = new Label();
            resultText = new TextBox();
            groupBoxIterations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weightC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weightB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weightA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIterations).BeginInit();
            groupBoxImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageWeight4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageWeight3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageWeight2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageWeight1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture1).BeginInit();
            groupBoxStrings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wordWeight1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordWeight2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordWeight3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordWeight4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordWeight5).BeginInit();
            SuspendLayout();
            // 
            // groupBoxIterations
            // 
            groupBoxIterations.Controls.Add(rollCountD);
            groupBoxIterations.Controls.Add(weightD);
            groupBoxIterations.Controls.Add(optionD);
            groupBoxIterations.Controls.Add(rollCountC);
            groupBoxIterations.Controls.Add(weightC);
            groupBoxIterations.Controls.Add(optionC);
            groupBoxIterations.Controls.Add(rollCountB);
            groupBoxIterations.Controls.Add(weightB);
            groupBoxIterations.Controls.Add(optionB);
            groupBoxIterations.Controls.Add(rollCountA);
            groupBoxIterations.Controls.Add(weightA);
            groupBoxIterations.Controls.Add(optionA);
            groupBoxIterations.Controls.Add(labelRollCountTitle);
            groupBoxIterations.Controls.Add(labelIterationWeightsTitle);
            groupBoxIterations.Controls.Add(labelIterationOptionsTitle);
            groupBoxIterations.Controls.Add(trackBarIterations);
            groupBoxIterations.Controls.Add(textBoxIterationCount);
            groupBoxIterations.Controls.Add(labelIterationCountLabel);
            groupBoxIterations.Controls.Add(buttonRunIterations);
            groupBoxIterations.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxIterations.Location = new Point(0, 0);
            groupBoxIterations.Name = "groupBoxIterations";
            groupBoxIterations.Size = new Size(798, 205);
            groupBoxIterations.TabIndex = 0;
            groupBoxIterations.TabStop = false;
            groupBoxIterations.Text = "Iterations Demo";
            // 
            // rollCountD
            // 
            rollCountD.Location = new Point(268, 151);
            rollCountD.MarqueeAnimationSpeed = 0;
            rollCountD.Name = "rollCountD";
            rollCountD.Size = new Size(200, 23);
            rollCountD.Step = 1;
            rollCountD.Style = ProgressBarStyle.Continuous;
            rollCountD.TabIndex = 18;
            // 
            // weightD
            // 
            weightD.Location = new Point(62, 149);
            weightD.Maximum = 100;
            weightD.Minimum = 1;
            weightD.Name = "weightD";
            weightD.Size = new Size(200, 45);
            weightD.TabIndex = 17;
            weightD.Value = 50;
            // 
            // optionD
            // 
            optionD.BorderStyle = BorderStyle.None;
            optionD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            optionD.Location = new Point(26, 149);
            optionD.MaxLength = 1;
            optionD.Name = "optionD";
            optionD.ReadOnly = true;
            optionD.Size = new Size(15, 25);
            optionD.TabIndex = 16;
            optionD.TabStop = false;
            optionD.Text = "D";
            // 
            // rollCountC
            // 
            rollCountC.Location = new Point(268, 124);
            rollCountC.MarqueeAnimationSpeed = 0;
            rollCountC.Name = "rollCountC";
            rollCountC.Size = new Size(200, 23);
            rollCountC.Step = 1;
            rollCountC.Style = ProgressBarStyle.Continuous;
            rollCountC.TabIndex = 15;
            // 
            // weightC
            // 
            weightC.Location = new Point(62, 122);
            weightC.Maximum = 100;
            weightC.Minimum = 1;
            weightC.Name = "weightC";
            weightC.Size = new Size(200, 45);
            weightC.TabIndex = 14;
            weightC.Value = 50;
            // 
            // optionC
            // 
            optionC.BorderStyle = BorderStyle.None;
            optionC.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            optionC.Location = new Point(26, 122);
            optionC.MaxLength = 1;
            optionC.Name = "optionC";
            optionC.ReadOnly = true;
            optionC.Size = new Size(15, 25);
            optionC.TabIndex = 13;
            optionC.TabStop = false;
            optionC.Text = "C";
            // 
            // rollCountB
            // 
            rollCountB.Location = new Point(268, 97);
            rollCountB.MarqueeAnimationSpeed = 0;
            rollCountB.Name = "rollCountB";
            rollCountB.Size = new Size(200, 23);
            rollCountB.Step = 1;
            rollCountB.Style = ProgressBarStyle.Continuous;
            rollCountB.TabIndex = 12;
            // 
            // weightB
            // 
            weightB.Location = new Point(62, 95);
            weightB.Maximum = 100;
            weightB.Minimum = 1;
            weightB.Name = "weightB";
            weightB.Size = new Size(200, 45);
            weightB.TabIndex = 11;
            weightB.Value = 50;
            // 
            // optionB
            // 
            optionB.BorderStyle = BorderStyle.None;
            optionB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            optionB.Location = new Point(26, 95);
            optionB.MaxLength = 1;
            optionB.Name = "optionB";
            optionB.ReadOnly = true;
            optionB.Size = new Size(15, 25);
            optionB.TabIndex = 10;
            optionB.TabStop = false;
            optionB.Text = "B";
            // 
            // rollCountA
            // 
            rollCountA.Location = new Point(268, 70);
            rollCountA.MarqueeAnimationSpeed = 0;
            rollCountA.Name = "rollCountA";
            rollCountA.Size = new Size(200, 23);
            rollCountA.Step = 1;
            rollCountA.Style = ProgressBarStyle.Continuous;
            rollCountA.TabIndex = 9;
            // 
            // weightA
            // 
            weightA.Location = new Point(62, 68);
            weightA.Maximum = 100;
            weightA.Minimum = 1;
            weightA.Name = "weightA";
            weightA.Size = new Size(200, 45);
            weightA.TabIndex = 8;
            weightA.Value = 50;
            // 
            // optionA
            // 
            optionA.BorderStyle = BorderStyle.None;
            optionA.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            optionA.Location = new Point(26, 68);
            optionA.MaxLength = 1;
            optionA.Name = "optionA";
            optionA.ReadOnly = true;
            optionA.Size = new Size(15, 25);
            optionA.TabIndex = 7;
            optionA.TabStop = false;
            optionA.Text = "A";
            // 
            // labelRollCountTitle
            // 
            labelRollCountTitle.AutoSize = true;
            labelRollCountTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelRollCountTitle.Location = new Point(268, 50);
            labelRollCountTitle.Name = "labelRollCountTitle";
            labelRollCountTitle.Size = new Size(64, 15);
            labelRollCountTitle.TabIndex = 6;
            labelRollCountTitle.Text = "Roll Count";
            // 
            // labelIterationWeightsTitle
            // 
            labelIterationWeightsTitle.AutoSize = true;
            labelIterationWeightsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIterationWeightsTitle.Location = new Point(62, 50);
            labelIterationWeightsTitle.Name = "labelIterationWeightsTitle";
            labelIterationWeightsTitle.Size = new Size(53, 15);
            labelIterationWeightsTitle.TabIndex = 5;
            labelIterationWeightsTitle.Text = "Weights";
            // 
            // labelIterationOptionsTitle
            // 
            labelIterationOptionsTitle.AutoSize = true;
            labelIterationOptionsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIterationOptionsTitle.Location = new Point(6, 50);
            labelIterationOptionsTitle.Name = "labelIterationOptionsTitle";
            labelIterationOptionsTitle.Size = new Size(50, 15);
            labelIterationOptionsTitle.TabIndex = 4;
            labelIterationOptionsTitle.Text = "Options";
            // 
            // trackBarIterations
            // 
            trackBarIterations.Location = new Point(216, 12);
            trackBarIterations.Maximum = 1000000;
            trackBarIterations.Minimum = 100;
            trackBarIterations.Name = "trackBarIterations";
            trackBarIterations.Size = new Size(572, 45);
            trackBarIterations.TabIndex = 3;
            trackBarIterations.Value = 10000;
            trackBarIterations.ValueChanged += trackBarIterations_ValueChanged;
            // 
            // textBoxIterationCount
            // 
            textBoxIterationCount.Location = new Point(149, 19);
            textBoxIterationCount.Name = "textBoxIterationCount";
            textBoxIterationCount.ReadOnly = true;
            textBoxIterationCount.Size = new Size(61, 23);
            textBoxIterationCount.TabIndex = 2;
            // 
            // labelIterationCountLabel
            // 
            labelIterationCountLabel.AutoSize = true;
            labelIterationCountLabel.Location = new Point(84, 23);
            labelIterationCountLabel.Name = "labelIterationCountLabel";
            labelIterationCountLabel.Size = new Size(64, 15);
            labelIterationCountLabel.TabIndex = 1;
            labelIterationCountLabel.Text = "Iterations:";
            // 
            // buttonRunIterations
            // 
            buttonRunIterations.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRunIterations.Location = new Point(3, 19);
            buttonRunIterations.Name = "buttonRunIterations";
            buttonRunIterations.Size = new Size(75, 23);
            buttonRunIterations.TabIndex = 0;
            buttonRunIterations.Text = "Run";
            buttonRunIterations.UseVisualStyleBackColor = true;
            buttonRunIterations.Click += buttonRunIterations_Click;
            // 
            // groupBoxImages
            // 
            groupBoxImages.Controls.Add(resultImage);
            groupBoxImages.Controls.Add(imageWeight4);
            groupBoxImages.Controls.Add(picture4);
            groupBoxImages.Controls.Add(imageWeight3);
            groupBoxImages.Controls.Add(picture3);
            groupBoxImages.Controls.Add(imageWeight2);
            groupBoxImages.Controls.Add(picture2);
            groupBoxImages.Controls.Add(imageWeight1);
            groupBoxImages.Controls.Add(labelImageWeightsTitle);
            groupBoxImages.Controls.Add(labelImageOptionsTitle);
            groupBoxImages.Controls.Add(picture1);
            groupBoxImages.Controls.Add(buttonGetImage);
            groupBoxImages.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxImages.Location = new Point(0, 211);
            groupBoxImages.Name = "groupBoxImages";
            groupBoxImages.Size = new Size(798, 221);
            groupBoxImages.TabIndex = 1;
            groupBoxImages.TabStop = false;
            groupBoxImages.Text = "Image Demo";
            // 
            // resultImage
            // 
            resultImage.Location = new Point(268, 19);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(184, 184);
            resultImage.SizeMode = PictureBoxSizeMode.StretchImage;
            resultImage.TabIndex = 25;
            resultImage.TabStop = false;
            // 
            // imageWeight4
            // 
            imageWeight4.Location = new Point(62, 173);
            imageWeight4.Maximum = 100;
            imageWeight4.Minimum = 1;
            imageWeight4.Name = "imageWeight4";
            imageWeight4.Size = new Size(200, 45);
            imageWeight4.TabIndex = 24;
            imageWeight4.Value = 50;
            // 
            // picture4
            // 
            picture4.Image = Properties.Resources.pexels_nikolaeva_nastia_9540183;
            picture4.Location = new Point(12, 173);
            picture4.Name = "picture4";
            picture4.Size = new Size(30, 30);
            picture4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture4.TabIndex = 23;
            picture4.TabStop = false;
            // 
            // imageWeight3
            // 
            imageWeight3.Location = new Point(62, 137);
            imageWeight3.Maximum = 100;
            imageWeight3.Minimum = 1;
            imageWeight3.Name = "imageWeight3";
            imageWeight3.Size = new Size(200, 45);
            imageWeight3.TabIndex = 22;
            imageWeight3.Value = 50;
            // 
            // picture3
            // 
            picture3.Image = Properties.Resources.pexels_jill_wellington_3776950;
            picture3.Location = new Point(12, 137);
            picture3.Name = "picture3";
            picture3.Size = new Size(30, 30);
            picture3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture3.TabIndex = 21;
            picture3.TabStop = false;
            // 
            // imageWeight2
            // 
            imageWeight2.Location = new Point(62, 101);
            imageWeight2.Maximum = 100;
            imageWeight2.Minimum = 1;
            imageWeight2.Name = "imageWeight2";
            imageWeight2.Size = new Size(200, 45);
            imageWeight2.TabIndex = 20;
            imageWeight2.Value = 50;
            // 
            // picture2
            // 
            picture2.Image = Properties.Resources.pexels_andie_3746517;
            picture2.Location = new Point(12, 101);
            picture2.Name = "picture2";
            picture2.Size = new Size(30, 30);
            picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture2.TabIndex = 19;
            picture2.TabStop = false;
            // 
            // imageWeight1
            // 
            imageWeight1.Location = new Point(62, 65);
            imageWeight1.Maximum = 100;
            imageWeight1.Minimum = 1;
            imageWeight1.Name = "imageWeight1";
            imageWeight1.Size = new Size(200, 45);
            imageWeight1.TabIndex = 18;
            imageWeight1.Value = 50;
            // 
            // labelImageWeightsTitle
            // 
            labelImageWeightsTitle.AutoSize = true;
            labelImageWeightsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelImageWeightsTitle.Location = new Point(62, 47);
            labelImageWeightsTitle.Name = "labelImageWeightsTitle";
            labelImageWeightsTitle.Size = new Size(53, 15);
            labelImageWeightsTitle.TabIndex = 7;
            labelImageWeightsTitle.Text = "Weights";
            // 
            // labelImageOptionsTitle
            // 
            labelImageOptionsTitle.AutoSize = true;
            labelImageOptionsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelImageOptionsTitle.Location = new Point(6, 47);
            labelImageOptionsTitle.Name = "labelImageOptionsTitle";
            labelImageOptionsTitle.Size = new Size(50, 15);
            labelImageOptionsTitle.TabIndex = 6;
            labelImageOptionsTitle.Text = "Options";
            // 
            // picture1
            // 
            picture1.Image = Properties.Resources.pexels_andie_3647046;
            picture1.Location = new Point(12, 65);
            picture1.Name = "picture1";
            picture1.Size = new Size(30, 30);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 1;
            picture1.TabStop = false;
            // 
            // buttonGetImage
            // 
            buttonGetImage.AutoSize = true;
            buttonGetImage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGetImage.Location = new Point(3, 19);
            buttonGetImage.Name = "buttonGetImage";
            buttonGetImage.Size = new Size(107, 25);
            buttonGetImage.TabIndex = 0;
            buttonGetImage.Text = "Roll for an image";
            buttonGetImage.UseVisualStyleBackColor = true;
            buttonGetImage.Click += buttonGetImage_Click;
            // 
            // groupBoxStrings
            // 
            groupBoxStrings.Controls.Add(resultText);
            groupBoxStrings.Controls.Add(labelWordResultTitle);
            groupBoxStrings.Controls.Add(wordWeight5);
            groupBoxStrings.Controls.Add(wordWeight4);
            groupBoxStrings.Controls.Add(wordWeight3);
            groupBoxStrings.Controls.Add(wordWeight2);
            groupBoxStrings.Controls.Add(wordWeight1);
            groupBoxStrings.Controls.Add(word5);
            groupBoxStrings.Controls.Add(word4);
            groupBoxStrings.Controls.Add(word3);
            groupBoxStrings.Controls.Add(word2);
            groupBoxStrings.Controls.Add(word1);
            groupBoxStrings.Controls.Add(labelWordWeightsTitle);
            groupBoxStrings.Controls.Add(labelWordOptionsTitle);
            groupBoxStrings.Controls.Add(buttonGetWord);
            groupBoxStrings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxStrings.Location = new Point(0, 438);
            groupBoxStrings.Name = "groupBoxStrings";
            groupBoxStrings.Size = new Size(798, 233);
            groupBoxStrings.TabIndex = 2;
            groupBoxStrings.TabStop = false;
            groupBoxStrings.Text = "Word Demo";
            // 
            // labelWordWeightsTitle
            // 
            labelWordWeightsTitle.AutoSize = true;
            labelWordWeightsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelWordWeightsTitle.Location = new Point(62, 47);
            labelWordWeightsTitle.Name = "labelWordWeightsTitle";
            labelWordWeightsTitle.Size = new Size(53, 15);
            labelWordWeightsTitle.TabIndex = 9;
            labelWordWeightsTitle.Text = "Weights";
            // 
            // labelWordOptionsTitle
            // 
            labelWordOptionsTitle.AutoSize = true;
            labelWordOptionsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelWordOptionsTitle.Location = new Point(6, 47);
            labelWordOptionsTitle.Name = "labelWordOptionsTitle";
            labelWordOptionsTitle.Size = new Size(50, 15);
            labelWordOptionsTitle.TabIndex = 8;
            labelWordOptionsTitle.Text = "Options";
            // 
            // buttonGetWord
            // 
            buttonGetWord.AutoSize = true;
            buttonGetWord.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGetWord.Location = new Point(3, 19);
            buttonGetWord.Name = "buttonGetWord";
            buttonGetWord.Size = new Size(94, 25);
            buttonGetWord.TabIndex = 0;
            buttonGetWord.Text = "Roll for a word";
            buttonGetWord.UseVisualStyleBackColor = true;
            buttonGetWord.Click += buttonGetWord_Click;
            // 
            // word1
            // 
            word1.BorderStyle = BorderStyle.None;
            word1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            word1.Location = new Point(6, 65);
            word1.MaxLength = 0;
            word1.Name = "word1";
            word1.ReadOnly = true;
            word1.Size = new Size(55, 25);
            word1.TabIndex = 11;
            word1.TabStop = false;
            word1.Text = "Lorem";
            word1.WordWrap = false;
            // 
            // word2
            // 
            word2.BorderStyle = BorderStyle.None;
            word2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            word2.Location = new Point(6, 96);
            word2.MaxLength = 0;
            word2.Name = "word2";
            word2.ReadOnly = true;
            word2.Size = new Size(55, 25);
            word2.TabIndex = 12;
            word2.TabStop = false;
            word2.Text = "Ipsum";
            word2.WordWrap = false;
            // 
            // word3
            // 
            word3.BorderStyle = BorderStyle.None;
            word3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            word3.Location = new Point(6, 127);
            word3.MaxLength = 0;
            word3.Name = "word3";
            word3.ReadOnly = true;
            word3.Size = new Size(55, 25);
            word3.TabIndex = 13;
            word3.TabStop = false;
            word3.Text = "Dolor";
            word3.WordWrap = false;
            // 
            // word4
            // 
            word4.BorderStyle = BorderStyle.None;
            word4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            word4.Location = new Point(6, 158);
            word4.MaxLength = 0;
            word4.Name = "word4";
            word4.ReadOnly = true;
            word4.Size = new Size(55, 25);
            word4.TabIndex = 14;
            word4.TabStop = false;
            word4.Text = "Sit";
            word4.WordWrap = false;
            // 
            // word5
            // 
            word5.BorderStyle = BorderStyle.None;
            word5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            word5.Location = new Point(6, 189);
            word5.MaxLength = 0;
            word5.Name = "word5";
            word5.ReadOnly = true;
            word5.Size = new Size(55, 25);
            word5.TabIndex = 15;
            word5.TabStop = false;
            word5.Text = "Amet";
            word5.WordWrap = false;
            // 
            // wordWeight1
            // 
            wordWeight1.Location = new Point(62, 65);
            wordWeight1.Maximum = 100;
            wordWeight1.Minimum = 1;
            wordWeight1.Name = "wordWeight1";
            wordWeight1.Size = new Size(200, 45);
            wordWeight1.TabIndex = 19;
            wordWeight1.Value = 50;
            // 
            // wordWeight2
            // 
            wordWeight2.Location = new Point(62, 96);
            wordWeight2.Maximum = 100;
            wordWeight2.Minimum = 1;
            wordWeight2.Name = "wordWeight2";
            wordWeight2.Size = new Size(200, 45);
            wordWeight2.TabIndex = 20;
            wordWeight2.Value = 50;
            // 
            // wordWeight3
            // 
            wordWeight3.Location = new Point(62, 127);
            wordWeight3.Maximum = 100;
            wordWeight3.Minimum = 1;
            wordWeight3.Name = "wordWeight3";
            wordWeight3.Size = new Size(200, 45);
            wordWeight3.TabIndex = 21;
            wordWeight3.Value = 50;
            // 
            // wordWeight4
            // 
            wordWeight4.Location = new Point(62, 158);
            wordWeight4.Maximum = 100;
            wordWeight4.Minimum = 1;
            wordWeight4.Name = "wordWeight4";
            wordWeight4.Size = new Size(200, 45);
            wordWeight4.TabIndex = 22;
            wordWeight4.Value = 50;
            // 
            // wordWeight5
            // 
            wordWeight5.Location = new Point(62, 189);
            wordWeight5.Maximum = 100;
            wordWeight5.Minimum = 1;
            wordWeight5.Name = "wordWeight5";
            wordWeight5.Size = new Size(200, 45);
            wordWeight5.TabIndex = 23;
            wordWeight5.Value = 50;
            // 
            // labelWordResultTitle
            // 
            labelWordResultTitle.AutoSize = true;
            labelWordResultTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelWordResultTitle.Location = new Point(268, 47);
            labelWordResultTitle.Name = "labelWordResultTitle";
            labelWordResultTitle.Size = new Size(66, 15);
            labelWordResultTitle.TabIndex = 24;
            labelWordResultTitle.Text = "Roll Result";
            // 
            // resultText
            // 
            resultText.BorderStyle = BorderStyle.None;
            resultText.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            resultText.Location = new Point(268, 113);
            resultText.MaxLength = 0;
            resultText.Name = "resultText";
            resultText.PlaceholderText = "<roll for a random string>";
            resultText.ReadOnly = true;
            resultText.Size = new Size(524, 39);
            resultText.TabIndex = 25;
            resultText.TabStop = false;
            resultText.TextAlign = HorizontalAlignment.Center;
            resultText.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 673);
            Controls.Add(groupBoxStrings);
            Controls.Add(groupBoxImages);
            Controls.Add(groupBoxIterations);
            Name = "Form1";
            Text = "WeightedRandom WindowsForms Demo";
            Load += Form1_Load;
            groupBoxIterations.ResumeLayout(false);
            groupBoxIterations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightD).EndInit();
            ((System.ComponentModel.ISupportInitialize)weightC).EndInit();
            ((System.ComponentModel.ISupportInitialize)weightB).EndInit();
            ((System.ComponentModel.ISupportInitialize)weightA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIterations).EndInit();
            groupBoxImages.ResumeLayout(false);
            groupBoxImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageWeight4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture4).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageWeight3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture3).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageWeight2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageWeight1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture1).EndInit();
            groupBoxStrings.ResumeLayout(false);
            groupBoxStrings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wordWeight1).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordWeight2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordWeight3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordWeight4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordWeight5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIterations;
        private GroupBox groupBoxImages;
        private GroupBox groupBoxStrings;
        private Button buttonRunIterations;
        private Label labelIterationCountLabel;
        private Button buttonGetImage;
        private Button buttonGetWord;
        private TrackBar trackBarIterations;
        private TextBox textBoxIterationCount;
        private Label labelIterationOptionsTitle;
        private Label labelRollCountTitle;
        private Label labelIterationWeightsTitle;
        private TextBox optionA;
        private ProgressBar rollCountA;
        private TrackBar weightA;
        private ProgressBar rollCountD;
        private TrackBar weightD;
        private TextBox optionD;
        private ProgressBar rollCountC;
        private TrackBar weightC;
        private TextBox optionC;
        private ProgressBar rollCountB;
        private TrackBar weightB;
        private TextBox optionB;
        private PictureBox picture1;
        private Label labelImageWeightsTitle;
        private Label labelImageOptionsTitle;
        private TrackBar imageWeight1;
        private TrackBar imageWeight4;
        private PictureBox picture4;
        private TrackBar imageWeight3;
        private PictureBox picture3;
        private TrackBar imageWeight2;
        private PictureBox picture2;
        private PictureBox resultImage;
        private Label labelWordWeightsTitle;
        private Label labelWordOptionsTitle;
        private TextBox word1;
        private TextBox word3;
        private TextBox word2;
        private TrackBar wordWeight5;
        private TrackBar wordWeight4;
        private TrackBar wordWeight3;
        private TrackBar wordWeight2;
        private TrackBar wordWeight1;
        private TextBox word5;
        private TextBox word4;
        private TextBox resultText;
        private Label labelWordResultTitle;
    }
}