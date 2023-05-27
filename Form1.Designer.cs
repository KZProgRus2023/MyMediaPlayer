using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using WMPLib;

namespace MyMediaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитькакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйпросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Воспроизвести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.сохранитькакToolStripMenuItem,
            this.toolStripSeparator1,
            this.печатьToolStripMenuItem,
            this.предварительныйпросмотрToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.создатьToolStripMenuItem.Text = "&Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(230, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // сохранитькакToolStripMenuItem
            // 
            this.сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            this.сохранитькакToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripMenuItem.Image")));
            this.печатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.печатьToolStripMenuItem.Text = "&Печать";
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            this.предварительныйпросмотрToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image")));
            this.предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            this.предварительныйпросмотрToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.предварительныйпросмотрToolStripMenuItem.Text = "Предварительный про&смотр";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(230, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменадействияToolStripMenuItem,
            this.отменадействияToolStripMenuItem1,
            this.toolStripSeparator3,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставкаToolStripMenuItem,
            this.toolStripSeparator4,
            this.выделитьвсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // отменадействияToolStripMenuItem
            // 
            this.отменадействияToolStripMenuItem.Name = "отменадействияToolStripMenuItem";
            this.отменадействияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменадействияToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.отменадействияToolStripMenuItem.Text = "&Отмена действия";
            // 
            // отменадействияToolStripMenuItem1
            // 
            this.отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
            this.отменадействияToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.отменадействияToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.отменадействияToolStripMenuItem1.Text = "&Отмена действия";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.Image")));
            this.вырезатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезат&ь";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.Image")));
            this.копироватьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.копироватьToolStripMenuItem.Text = "&Копировать";
            // 
            // вставкаToolStripMenuItem
            // 
            this.вставкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripMenuItem.Image")));
            this.вставкаToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            this.вставкаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вставкаToolStripMenuItem.Text = "Вст&авка";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
            // 
            // выделитьвсеToolStripMenuItem
            // 
            this.выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
            this.выделитьвсеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.выделитьвсеToolStripMenuItem.Text = "Выделить &все";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "&Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.параметрыToolStripMenuItem.Text = "&Параметры";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.индексToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.toolStripSeparator5,
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.содержаниеToolStripMenuItem.Text = "&Содержание";
            // 
            // индексToolStripMenuItem
            // 
            this.индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            this.индексToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 24);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(613, 374);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.axWindowsMediaPlayer1_MediaError);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e) => throw new NotImplementedException();

        public override bool Equals(object obj)
        {
            return obj is Form1 form &&
                   CanRaiseEvents == form.CanRaiseEvents &&
                   EqualityComparer<EventHandlerList>.Default.Equals(Events, form.Events) &&
                   EqualityComparer<ISite>.Default.Equals(Site, form.Site) &&
                   EqualityComparer<IContainer>.Default.Equals(Container, form.Container) &&
                   DesignMode == form.DesignMode &&
                   EqualityComparer<AccessibleObject>.Default.Equals(AccessibilityObject, form.AccessibilityObject) &&
                   AccessibleDefaultActionDescription == form.AccessibleDefaultActionDescription &&
                   AccessibleDescription == form.AccessibleDescription &&
                   AccessibleName == form.AccessibleName &&
                   AccessibleRole == form.AccessibleRole &&
                   AllowDrop == form.AllowDrop &&
                   Anchor == form.Anchor &&
                   AutoSize == form.AutoSize &&
                   EqualityComparer<Point>.Default.Equals(AutoScrollOffset, form.AutoScrollOffset) &&
                   EqualityComparer<LayoutEngine>.Default.Equals(LayoutEngine, form.LayoutEngine) &&
                   EqualityComparer<Color>.Default.Equals(BackColor, form.BackColor) &&
                   EqualityComparer<Image>.Default.Equals(BackgroundImage, form.BackgroundImage) &&
                   BackgroundImageLayout == form.BackgroundImageLayout &&
                   EqualityComparer<BindingContext>.Default.Equals(BindingContext, form.BindingContext) &&
                   Bottom == form.Bottom &&
                   EqualityComparer<Rectangle>.Default.Equals(Bounds, form.Bounds) &&
                   CanFocus == form.CanFocus &&
                   CanRaiseEvents == form.CanRaiseEvents &&
                   CanSelect == form.CanSelect &&
                   Capture == form.Capture &&
                   CausesValidation == form.CausesValidation &&
                   EqualityComparer<Rectangle>.Default.Equals(ClientRectangle, form.ClientRectangle) &&
                   EqualityComparer<Size>.Default.Equals(ClientSize, form.ClientSize) &&
                   CompanyName == form.CompanyName &&
                   ContainsFocus == form.ContainsFocus &&
                   EqualityComparer<ContextMenu>.Default.Equals(ContextMenu, form.ContextMenu) &&
                   EqualityComparer<ContextMenuStrip>.Default.Equals(ContextMenuStrip, form.ContextMenuStrip) &&
                   EqualityComparer<Control.ControlCollection>.Default.Equals(Controls, form.Controls) &&
                   Created == form.Created &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, form.CreateParams) &&
                   EqualityComparer<Cursor>.Default.Equals(Cursor, form.Cursor) &&
                   EqualityComparer<ControlBindingsCollection>.Default.Equals(DataBindings, form.DataBindings) &&
                   EqualityComparer<Cursor>.Default.Equals(DefaultCursor, form.DefaultCursor) &&
                   EqualityComparer<Padding>.Default.Equals(DefaultMargin, form.DefaultMargin) &&
                   EqualityComparer<Size>.Default.Equals(DefaultMaximumSize, form.DefaultMaximumSize) &&
                   EqualityComparer<Size>.Default.Equals(DefaultMinimumSize, form.DefaultMinimumSize) &&
                   EqualityComparer<Padding>.Default.Equals(DefaultPadding, form.DefaultPadding) &&
                   EqualityComparer<Size>.Default.Equals(DefaultSize, form.DefaultSize) &&
                   DeviceDpi == form.DeviceDpi &&
                   EqualityComparer<Rectangle>.Default.Equals(DisplayRectangle, form.DisplayRectangle) &&
                   IsDisposed == form.IsDisposed &&
                   Disposing == form.Disposing &&
                   Dock == form.Dock &&
                   DoubleBuffered == form.DoubleBuffered &&
                   Enabled == form.Enabled &&
                   Focused == form.Focused &&
                   EqualityComparer<Font>.Default.Equals(Font, form.Font) &&
                   FontHeight == form.FontHeight &&
                   EqualityComparer<Color>.Default.Equals(ForeColor, form.ForeColor) &&
                   EqualityComparer<IntPtr>.Default.Equals(Handle, form.Handle) &&
                   HasChildren == form.HasChildren &&
                   Height == form.Height &&
                   IsHandleCreated == form.IsHandleCreated &&
                   InvokeRequired == form.InvokeRequired &&
                   IsAccessible == form.IsAccessible &&
                   IsMirrored == form.IsMirrored &&
                   Left == form.Left &&
                   EqualityComparer<Point>.Default.Equals(Location, form.Location) &&
                   EqualityComparer<Padding>.Default.Equals(Margin, form.Margin) &&
                   EqualityComparer<Size>.Default.Equals(MaximumSize, form.MaximumSize) &&
                   EqualityComparer<Size>.Default.Equals(MinimumSize, form.MinimumSize) &&
                   Name == form.Name &&
                   EqualityComparer<Control>.Default.Equals(Parent, form.Parent) &&
                   ProductName == form.ProductName &&
                   ProductVersion == form.ProductVersion &&
                   RecreatingHandle == form.RecreatingHandle &&
                   EqualityComparer<Region>.Default.Equals(Region, form.Region) &&
                   RenderRightToLeft == form.RenderRightToLeft &&
                   ResizeRedraw == form.ResizeRedraw &&
                   Right == form.Right &&
                   RightToLeft == form.RightToLeft &&
                   ScaleChildren == form.ScaleChildren &&
                   EqualityComparer<ISite>.Default.Equals(Site, form.Site) &&
                   EqualityComparer<Size>.Default.Equals(Size, form.Size) &&
                   TabIndex == form.TabIndex &&
                   TabStop == form.TabStop &&
                   EqualityComparer<object>.Default.Equals(Tag, form.Tag) &&
                   Text == form.Text &&
                   Top == form.Top &&
                   EqualityComparer<Control>.Default.Equals(TopLevelControl, form.TopLevelControl) &&
                   ShowKeyboardCues == form.ShowKeyboardCues &&
                   ShowFocusCues == form.ShowFocusCues &&
                   UseWaitCursor == form.UseWaitCursor &&
                   Visible == form.Visible &&
                   Width == form.Width &&
                   EqualityComparer<IWindowTarget>.Default.Equals(WindowTarget, form.WindowTarget) &&
                   EqualityComparer<Size>.Default.Equals(PreferredSize, form.PreferredSize) &&
                   EqualityComparer<Padding>.Default.Equals(Padding, form.Padding) &&
                   CanEnableIme == form.CanEnableIme &&
                   DefaultImeMode == form.DefaultImeMode &&
                   ImeMode == form.ImeMode &&
                   ImeModeBase == form.ImeModeBase &&
                   AutoScroll == form.AutoScroll &&
                   EqualityComparer<Size>.Default.Equals(AutoScrollMargin, form.AutoScrollMargin) &&
                   EqualityComparer<Point>.Default.Equals(AutoScrollPosition, form.AutoScrollPosition) &&
                   EqualityComparer<Size>.Default.Equals(AutoScrollMinSize, form.AutoScrollMinSize) &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, form.CreateParams) &&
                   EqualityComparer<Rectangle>.Default.Equals(DisplayRectangle, form.DisplayRectangle) &&
                   HScroll == form.HScroll &&
                   EqualityComparer<HScrollProperties>.Default.Equals(HorizontalScroll, form.HorizontalScroll) &&
                   VScroll == form.VScroll &&
                   EqualityComparer<VScrollProperties>.Default.Equals(VerticalScroll, form.VerticalScroll) &&
                   EqualityComparer<DockPaddingEdges>.Default.Equals(DockPadding, form.DockPadding) &&
                   EqualityComparer<SizeF>.Default.Equals(AutoScaleDimensions, form.AutoScaleDimensions) &&
                   EqualityComparer<SizeF>.Default.Equals(AutoScaleFactor, form.AutoScaleFactor) &&
                   AutoScaleMode == form.AutoScaleMode &&
                   AutoValidate == form.AutoValidate &&
                   EqualityComparer<BindingContext>.Default.Equals(BindingContext, form.BindingContext) &&
                   CanEnableIme == form.CanEnableIme &&
                   EqualityComparer<Control>.Default.Equals(ActiveControl, form.ActiveControl) &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, form.CreateParams) &&
                   EqualityComparer<SizeF>.Default.Equals(CurrentAutoScaleDimensions, form.CurrentAutoScaleDimensions) &&
                   EqualityComparer<Form>.Default.Equals(ParentForm, form.ParentForm) &&
                   EqualityComparer<IButtonControl>.Default.Equals(AcceptButton, form.AcceptButton) &&
                   EqualityComparer<Form>.Default.Equals(ActiveMdiChild, form.ActiveMdiChild) &&
                   AllowTransparency == form.AllowTransparency &&
                   AutoScale == form.AutoScale &&
                   EqualityComparer<Size>.Default.Equals(AutoScaleBaseSize, form.AutoScaleBaseSize) &&
                   AutoScroll == form.AutoScroll &&
                   AutoSize == form.AutoSize &&
                   AutoSizeMode == form.AutoSizeMode &&
                   AutoValidate == form.AutoValidate &&
                   EqualityComparer<Color>.Default.Equals(BackColor, form.BackColor) &&
                   FormBorderStyle == form.FormBorderStyle &&
                   EqualityComparer<IButtonControl>.Default.Equals(CancelButton, form.CancelButton) &&
                   EqualityComparer<Size>.Default.Equals(ClientSize, form.ClientSize) &&
                   ControlBox == form.ControlBox &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, form.CreateParams) &&
                   DefaultImeMode == form.DefaultImeMode &&
                   EqualityComparer<Size>.Default.Equals(DefaultSize, form.DefaultSize) &&
                   EqualityComparer<Rectangle>.Default.Equals(DesktopBounds, form.DesktopBounds) &&
                   EqualityComparer<Point>.Default.Equals(DesktopLocation, form.DesktopLocation) &&
                   DialogResult == form.DialogResult &&
                   HelpButton == form.HelpButton &&
                   EqualityComparer<Icon>.Default.Equals(Icon, form.Icon) &&
                   IsMdiChild == form.IsMdiChild &&
                   IsMdiContainer == form.IsMdiContainer &&
                   IsRestrictedWindow == form.IsRestrictedWindow &&
                   KeyPreview == form.KeyPreview &&
                   EqualityComparer<Point>.Default.Equals(Location, form.Location) &&
                   EqualityComparer<Rectangle>.Default.Equals(MaximizedBounds, form.MaximizedBounds) &&
                   EqualityComparer<Size>.Default.Equals(MaximumSize, form.MaximumSize) &&
                   EqualityComparer<MenuStrip>.Default.Equals(MainMenuStrip, form.MainMenuStrip) &&
                   EqualityComparer<Padding>.Default.Equals(Margin, form.Margin) &&
                   EqualityComparer<MainMenu>.Default.Equals(Menu, form.Menu) &&
                   EqualityComparer<Size>.Default.Equals(MinimumSize, form.MinimumSize) &&
                   MaximizeBox == form.MaximizeBox &&
                   EqualityComparer<Form[]>.Default.Equals(MdiChildren, form.MdiChildren) &&
                   EqualityComparer<Form>.Default.Equals(MdiParent, form.MdiParent) &&
                   EqualityComparer<MainMenu>.Default.Equals(MergedMenu, form.MergedMenu) &&
                   MinimizeBox == form.MinimizeBox &&
                   Modal == form.Modal &&
                   Opacity == form.Opacity &&
                   EqualityComparer<Form[]>.Default.Equals(OwnedForms, form.OwnedForms) &&
                   EqualityComparer<Form>.Default.Equals(Owner, form.Owner) &&
                   EqualityComparer<Rectangle>.Default.Equals(RestoreBounds, form.RestoreBounds) &&
                   RightToLeftLayout == form.RightToLeftLayout &&
                   ShowInTaskbar == form.ShowInTaskbar &&
                   ShowIcon == form.ShowIcon &&
                   ShowWithoutActivation == form.ShowWithoutActivation &&
                   EqualityComparer<Size>.Default.Equals(Size, form.Size) &&
                   SizeGripStyle == form.SizeGripStyle &&
                   StartPosition == form.StartPosition &&
                   TabIndex == form.TabIndex &&
                   TabStop == form.TabStop &&
                   Text == form.Text &&
                   TopLevel == form.TopLevel &&
                   TopMost == form.TopMost &&
                   EqualityComparer<Color>.Default.Equals(TransparencyKey, form.TransparencyKey) &&
                   WindowState == form.WindowState &&
                   EqualityComparer<WindowsMediaPlayer>.Default.Equals(Player, form.Player) &&
                   EqualityComparer<IContainer>.Default.Equals(components, form.components) &&
                   EqualityComparer<AxWindowsMediaPlayer>.Default.Equals(axWindowsMediaPlayer1, form.axWindowsMediaPlayer1) &&
                   EqualityComparer<Button>.Default.Equals(button1, form.button1) &&
                   EqualityComparer<Button>.Default.Equals(button2, form.button2) &&
                   EqualityComparer<OpenFileDialog>.Default.Equals(openFileDialog1, form.openFileDialog1) &&
                   EqualityComparer<SaveFileDialog>.Default.Equals(saveFileDialog1, form.saveFileDialog1) &&
                   EqualityComparer<MenuStrip>.Default.Equals(menuStrip1, form.menuStrip1) &&
                   EqualityComparer<MenuStrip>.Default.Equals(menuStrip2, form.menuStrip2) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(файлToolStripMenuItem, form.файлToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(создатьToolStripMenuItem, form.создатьToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(открытьToolStripMenuItem, form.открытьToolStripMenuItem) &&
                   EqualityComparer<ToolStripSeparator>.Default.Equals(toolStripSeparator, form.toolStripSeparator) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(сохранитьToolStripMenuItem, form.сохранитьToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(сохранитькакToolStripMenuItem, form.сохранитькакToolStripMenuItem) &&
                   EqualityComparer<ToolStripSeparator>.Default.Equals(toolStripSeparator1, form.toolStripSeparator1) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(печатьToolStripMenuItem, form.печатьToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(предварительныйпросмотрToolStripMenuItem, form.предварительныйпросмотрToolStripMenuItem) &&
                   EqualityComparer<ToolStripSeparator>.Default.Equals(toolStripSeparator2, form.toolStripSeparator2) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(выходToolStripMenuItem, form.выходToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(правкаToolStripMenuItem, form.правкаToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(отменадействияToolStripMenuItem, form.отменадействияToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(отменадействияToolStripMenuItem1, form.отменадействияToolStripMenuItem1) &&
                   EqualityComparer<ToolStripSeparator>.Default.Equals(toolStripSeparator3, form.toolStripSeparator3) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(вырезатьToolStripMenuItem, form.вырезатьToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(копироватьToolStripMenuItem, form.копироватьToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(вставкаToolStripMenuItem, form.вставкаToolStripMenuItem) &&
                   EqualityComparer<ToolStripSeparator>.Default.Equals(toolStripSeparator4, form.toolStripSeparator4) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(выделитьвсеToolStripMenuItem, form.выделитьвсеToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(сервисToolStripMenuItem, form.сервисToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(настройкиToolStripMenuItem, form.настройкиToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(параметрыToolStripMenuItem, form.параметрыToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(справкаToolStripMenuItem, form.справкаToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(содержаниеToolStripMenuItem, form.содержаниеToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(индексToolStripMenuItem, form.индексToolStripMenuItem) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(поискToolStripMenuItem, form.поискToolStripMenuItem) &&
                   EqualityComparer<ToolStripSeparator>.Default.Equals(toolStripSeparator5, form.toolStripSeparator5) &&
                   EqualityComparer<ToolStripMenuItem>.Default.Equals(опрограммеToolStripMenuItem, form.опрограммеToolStripMenuItem);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem выделитьвсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индексToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
    }
}

