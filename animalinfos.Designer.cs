
namespace PET_CLINIC
{
    partial class animalinfos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(animalinfos));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridanimal = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txt_chercher = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_ajouteranimal = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_modifieranimal = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_supp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridanimal)).BeginInit();
            this.SuspendLayout();
            // 
            // tel
            // 
            this.tel.HeaderText = "Téléphone ";
            this.tel.Name = "tel";
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse Propriétaire";
            this.adresse.Name = "adresse";
            // 
            // nompro
            // 
            this.nompro.HeaderText = "Nom Propriétaire";
            this.nompro.Name = "nompro";
            // 
            // alergie
            // 
            this.alergie.HeaderText = "Alergie";
            this.alergie.Name = "alergie";
            // 
            // categorie
            // 
            this.categorie.HeaderText = "Catégorie";
            this.categorie.Name = "categorie";
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom Animal";
            this.nom.Name = "nom";
            // 
            // datagridanimal
            // 
            this.datagridanimal.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datagridanimal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridanimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridanimal.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagridanimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridanimal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridanimal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridanimal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridanimal.ColumnHeadersHeight = 40;
            this.datagridanimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.genre,
            this.age,
            this.categorie,
            this.alergie,
            this.nompro,
            this.adresse,
            this.tel});
            this.datagridanimal.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.datagridanimal.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridanimal.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridanimal.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.datagridanimal.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridanimal.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.datagridanimal.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.datagridanimal.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.datagridanimal.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.datagridanimal.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridanimal.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.datagridanimal.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridanimal.CurrentTheme.Name = null;
            this.datagridanimal.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.datagridanimal.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridanimal.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridanimal.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.datagridanimal.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridanimal.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridanimal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridanimal.EnableHeadersVisualStyles = false;
            this.datagridanimal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.datagridanimal.HeaderBackColor = System.Drawing.Color.Navy;
            this.datagridanimal.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridanimal.HeaderForeColor = System.Drawing.Color.White;
            this.datagridanimal.Location = new System.Drawing.Point(0, 202);
            this.datagridanimal.MultiSelect = false;
            this.datagridanimal.Name = "datagridanimal";
            this.datagridanimal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridanimal.RowHeadersVisible = false;
            this.datagridanimal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridanimal.RowTemplate.Height = 40;
            this.datagridanimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridanimal.Size = new System.Drawing.Size(903, 343);
            this.datagridanimal.TabIndex = 1;
            this.datagridanimal.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            // 
            // txt_chercher
            // 
            this.txt_chercher.AcceptsReturn = false;
            this.txt_chercher.AcceptsTab = false;
            this.txt_chercher.AnimationSpeed = 200;
            this.txt_chercher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_chercher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_chercher.BackColor = System.Drawing.Color.Transparent;
            this.txt_chercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_chercher.BackgroundImage")));
            this.txt_chercher.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_chercher.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_chercher.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_chercher.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_chercher.BorderRadius = 4;
            this.txt_chercher.BorderThickness = 1;
            this.txt_chercher.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_chercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chercher.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_chercher.DefaultText = "";
            this.txt_chercher.FillColor = System.Drawing.Color.White;
            this.txt_chercher.HideSelection = true;
            this.txt_chercher.IconLeft = null;
            this.txt_chercher.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chercher.IconPadding = 10;
            this.txt_chercher.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_chercher.IconRight")));
            this.txt_chercher.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chercher.Lines = new string[0];
            this.txt_chercher.Location = new System.Drawing.Point(188, 51);
            this.txt_chercher.MaxLength = 32767;
            this.txt_chercher.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_chercher.Modified = false;
            this.txt_chercher.Multiline = false;
            this.txt_chercher.Name = "txt_chercher";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_chercher.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_chercher.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_chercher.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_chercher.OnIdleState = stateProperties4;
            this.txt_chercher.Padding = new System.Windows.Forms.Padding(3);
            this.txt_chercher.PasswordChar = '\0';
            this.txt_chercher.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_chercher.PlaceholderText = "";
            this.txt_chercher.ReadOnly = false;
            this.txt_chercher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_chercher.SelectedText = "";
            this.txt_chercher.SelectionLength = 0;
            this.txt_chercher.SelectionStart = 0;
            this.txt_chercher.ShortcutsEnabled = true;
            this.txt_chercher.Size = new System.Drawing.Size(178, 33);
            this.txt_chercher.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_chercher.TabIndex = 4;
            this.txt_chercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_chercher.TextMarginBottom = 0;
            this.txt_chercher.TextMarginLeft = 3;
            this.txt_chercher.TextMarginTop = 0;
            this.txt_chercher.TextPlaceholder = "";
            this.txt_chercher.UseSystemPasswordChar = false;
            this.txt_chercher.WordWrap = true;
            // 
            // btn_ajouteranimal
            // 
            this.btn_ajouteranimal.AllowAnimations = true;
            this.btn_ajouteranimal.AllowMouseEffects = true;
            this.btn_ajouteranimal.AllowToggling = false;
            this.btn_ajouteranimal.AnimationSpeed = 200;
            this.btn_ajouteranimal.AutoGenerateColors = false;
            this.btn_ajouteranimal.AutoRoundBorders = false;
            this.btn_ajouteranimal.AutoSizeLeftIcon = true;
            this.btn_ajouteranimal.AutoSizeRightIcon = true;
            this.btn_ajouteranimal.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btn_ajouteranimal.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajouteranimal.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_ajouteranimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ajouteranimal.BackgroundImage")));
            this.btn_ajouteranimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ajouteranimal.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ajouteranimal.ButtonText = "AJOUTER ";
            this.btn_ajouteranimal.ButtonTextMarginLeft = 0;
            this.btn_ajouteranimal.ColorContrastOnClick = 45;
            this.btn_ajouteranimal.ColorContrastOnHover = 45;
            this.btn_ajouteranimal.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_ajouteranimal.CustomizableEdges = borderEdges1;
            this.btn_ajouteranimal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ajouteranimal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_ajouteranimal.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_ajouteranimal.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_ajouteranimal.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_ajouteranimal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ajouteranimal.ForeColor = System.Drawing.Color.White;
            this.btn_ajouteranimal.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajouteranimal.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ajouteranimal.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_ajouteranimal.IconMarginLeft = 11;
            this.btn_ajouteranimal.IconPadding = 10;
            this.btn_ajouteranimal.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ajouteranimal.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ajouteranimal.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_ajouteranimal.IconSize = 25;
            this.btn_ajouteranimal.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ajouteranimal.IdleBorderRadius = 5;
            this.btn_ajouteranimal.IdleBorderThickness = 1;
            this.btn_ajouteranimal.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_ajouteranimal.IdleIconLeftImage = null;
            this.btn_ajouteranimal.IdleIconRightImage = ((System.Drawing.Image)(resources.GetObject("btn_ajouteranimal.IdleIconRightImage")));
            this.btn_ajouteranimal.IndicateFocus = false;
            this.btn_ajouteranimal.Location = new System.Drawing.Point(645, 18);
            this.btn_ajouteranimal.Name = "btn_ajouteranimal";
            this.btn_ajouteranimal.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_ajouteranimal.OnDisabledState.BorderRadius = 5;
            this.btn_ajouteranimal.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ajouteranimal.OnDisabledState.BorderThickness = 1;
            this.btn_ajouteranimal.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_ajouteranimal.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_ajouteranimal.OnDisabledState.IconLeftImage = null;
            this.btn_ajouteranimal.OnDisabledState.IconRightImage = null;
            this.btn_ajouteranimal.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_ajouteranimal.onHoverState.BorderRadius = 5;
            this.btn_ajouteranimal.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ajouteranimal.onHoverState.BorderThickness = 1;
            this.btn_ajouteranimal.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_ajouteranimal.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_ajouteranimal.onHoverState.IconLeftImage = null;
            this.btn_ajouteranimal.onHoverState.IconRightImage = null;
            this.btn_ajouteranimal.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ajouteranimal.OnIdleState.BorderRadius = 5;
            this.btn_ajouteranimal.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ajouteranimal.OnIdleState.BorderThickness = 1;
            this.btn_ajouteranimal.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_ajouteranimal.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_ajouteranimal.OnIdleState.IconLeftImage = null;
            this.btn_ajouteranimal.OnIdleState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("btn_ajouteranimal.OnIdleState.IconRightImage")));
            this.btn_ajouteranimal.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_ajouteranimal.OnPressedState.BorderRadius = 5;
            this.btn_ajouteranimal.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ajouteranimal.OnPressedState.BorderThickness = 1;
            this.btn_ajouteranimal.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_ajouteranimal.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_ajouteranimal.OnPressedState.IconLeftImage = null;
            this.btn_ajouteranimal.OnPressedState.IconRightImage = null;
            this.btn_ajouteranimal.Size = new System.Drawing.Size(153, 33);
            this.btn_ajouteranimal.TabIndex = 6;
            this.btn_ajouteranimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ajouteranimal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ajouteranimal.TextMarginLeft = 0;
            this.btn_ajouteranimal.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_ajouteranimal.UseDefaultRadiusAndThickness = true;
            this.btn_ajouteranimal.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(12, 63);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(154, 21);
            this.bunifuLabel5.TabIndex = 25;
            this.bunifuLabel5.Text = "Chercher un animal";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_modifieranimal
            // 
            this.btn_modifieranimal.AllowAnimations = true;
            this.btn_modifieranimal.AllowMouseEffects = true;
            this.btn_modifieranimal.AllowToggling = false;
            this.btn_modifieranimal.AnimationSpeed = 200;
            this.btn_modifieranimal.AutoGenerateColors = false;
            this.btn_modifieranimal.AutoRoundBorders = false;
            this.btn_modifieranimal.AutoSizeLeftIcon = true;
            this.btn_modifieranimal.AutoSizeRightIcon = true;
            this.btn_modifieranimal.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btn_modifieranimal.BackColor = System.Drawing.Color.Transparent;
            this.btn_modifieranimal.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_modifieranimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modifieranimal.BackgroundImage")));
            this.btn_modifieranimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_modifieranimal.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modifieranimal.ButtonText = "MODIFIER ";
            this.btn_modifieranimal.ButtonTextMarginLeft = 0;
            this.btn_modifieranimal.ColorContrastOnClick = 45;
            this.btn_modifieranimal.ColorContrastOnHover = 45;
            this.btn_modifieranimal.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_modifieranimal.CustomizableEdges = borderEdges2;
            this.btn_modifieranimal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_modifieranimal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_modifieranimal.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_modifieranimal.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_modifieranimal.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_modifieranimal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_modifieranimal.ForeColor = System.Drawing.Color.White;
            this.btn_modifieranimal.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modifieranimal.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_modifieranimal.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_modifieranimal.IconMarginLeft = 11;
            this.btn_modifieranimal.IconPadding = 10;
            this.btn_modifieranimal.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modifieranimal.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_modifieranimal.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_modifieranimal.IconSize = 25;
            this.btn_modifieranimal.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_modifieranimal.IdleBorderRadius = 5;
            this.btn_modifieranimal.IdleBorderThickness = 1;
            this.btn_modifieranimal.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_modifieranimal.IdleIconLeftImage = null;
            this.btn_modifieranimal.IdleIconRightImage = global::PET_CLINIC.Properties.Resources.crayon;
            this.btn_modifieranimal.IndicateFocus = false;
            this.btn_modifieranimal.Location = new System.Drawing.Point(645, 63);
            this.btn_modifieranimal.Name = "btn_modifieranimal";
            this.btn_modifieranimal.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_modifieranimal.OnDisabledState.BorderRadius = 5;
            this.btn_modifieranimal.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modifieranimal.OnDisabledState.BorderThickness = 1;
            this.btn_modifieranimal.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_modifieranimal.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_modifieranimal.OnDisabledState.IconLeftImage = null;
            this.btn_modifieranimal.OnDisabledState.IconRightImage = null;
            this.btn_modifieranimal.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_modifieranimal.onHoverState.BorderRadius = 5;
            this.btn_modifieranimal.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modifieranimal.onHoverState.BorderThickness = 1;
            this.btn_modifieranimal.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_modifieranimal.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_modifieranimal.onHoverState.IconLeftImage = null;
            this.btn_modifieranimal.onHoverState.IconRightImage = null;
            this.btn_modifieranimal.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_modifieranimal.OnIdleState.BorderRadius = 5;
            this.btn_modifieranimal.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modifieranimal.OnIdleState.BorderThickness = 1;
            this.btn_modifieranimal.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_modifieranimal.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_modifieranimal.OnIdleState.IconLeftImage = null;
            this.btn_modifieranimal.OnIdleState.IconRightImage = global::PET_CLINIC.Properties.Resources.crayon;
            this.btn_modifieranimal.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_modifieranimal.OnPressedState.BorderRadius = 5;
            this.btn_modifieranimal.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modifieranimal.OnPressedState.BorderThickness = 1;
            this.btn_modifieranimal.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_modifieranimal.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_modifieranimal.OnPressedState.IconLeftImage = null;
            this.btn_modifieranimal.OnPressedState.IconRightImage = null;
            this.btn_modifieranimal.Size = new System.Drawing.Size(153, 33);
            this.btn_modifieranimal.TabIndex = 26;
            this.btn_modifieranimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_modifieranimal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_modifieranimal.TextMarginLeft = 0;
            this.btn_modifieranimal.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_modifieranimal.UseDefaultRadiusAndThickness = true;
            // 
            // btn_supp
            // 
            this.btn_supp.AllowAnimations = true;
            this.btn_supp.AllowMouseEffects = true;
            this.btn_supp.AllowToggling = false;
            this.btn_supp.AnimationSpeed = 200;
            this.btn_supp.AutoGenerateColors = false;
            this.btn_supp.AutoRoundBorders = false;
            this.btn_supp.AutoSizeLeftIcon = true;
            this.btn_supp.AutoSizeRightIcon = true;
            this.btn_supp.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btn_supp.BackColor = System.Drawing.Color.Transparent;
            this.btn_supp.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_supp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_supp.BackgroundImage")));
            this.btn_supp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_supp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_supp.ButtonText = "SUPPRIMER";
            this.btn_supp.ButtonTextMarginLeft = 0;
            this.btn_supp.ColorContrastOnClick = 45;
            this.btn_supp.ColorContrastOnHover = 45;
            this.btn_supp.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_supp.CustomizableEdges = borderEdges3;
            this.btn_supp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_supp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_supp.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_supp.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_supp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_supp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_supp.ForeColor = System.Drawing.Color.White;
            this.btn_supp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_supp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_supp.IconMarginLeft = 11;
            this.btn_supp.IconPadding = 10;
            this.btn_supp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_supp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_supp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_supp.IconSize = 25;
            this.btn_supp.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_supp.IdleBorderRadius = 5;
            this.btn_supp.IdleBorderThickness = 1;
            this.btn_supp.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_supp.IdleIconLeftImage = null;
            this.btn_supp.IdleIconRightImage = null;
            this.btn_supp.IndicateFocus = false;
            this.btn_supp.Location = new System.Drawing.Point(645, 112);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_supp.OnDisabledState.BorderRadius = 5;
            this.btn_supp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_supp.OnDisabledState.BorderThickness = 1;
            this.btn_supp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_supp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_supp.OnDisabledState.IconLeftImage = null;
            this.btn_supp.OnDisabledState.IconRightImage = null;
            this.btn_supp.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_supp.onHoverState.BorderRadius = 5;
            this.btn_supp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_supp.onHoverState.BorderThickness = 1;
            this.btn_supp.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_supp.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_supp.onHoverState.IconLeftImage = null;
            this.btn_supp.onHoverState.IconRightImage = null;
            this.btn_supp.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_supp.OnIdleState.BorderRadius = 5;
            this.btn_supp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_supp.OnIdleState.BorderThickness = 1;
            this.btn_supp.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_supp.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_supp.OnIdleState.IconLeftImage = null;
            this.btn_supp.OnIdleState.IconRightImage = null;
            this.btn_supp.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_supp.OnPressedState.BorderRadius = 5;
            this.btn_supp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_supp.OnPressedState.BorderThickness = 1;
            this.btn_supp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_supp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_supp.OnPressedState.IconLeftImage = null;
            this.btn_supp.OnPressedState.IconRightImage = null;
            this.btn_supp.Size = new System.Drawing.Size(153, 33);
            this.btn_supp.TabIndex = 27;
            this.btn_supp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_supp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_supp.TextMarginLeft = 0;
            this.btn_supp.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_supp.UseDefaultRadiusAndThickness = true;
            // 
            // animalinfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(903, 545);
            this.ControlBox = false;
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.btn_modifieranimal);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.btn_ajouteranimal);
            this.Controls.Add(this.txt_chercher);
            this.Controls.Add(this.datagridanimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "animalinfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.datagridanimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompro;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergie;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridanimal;
        private Bunifu.UI.WinForms.BunifuTextBox txt_chercher;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_ajouteranimal;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_modifieranimal;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_supp;
    }
}