Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Dim CommandBarStripInfoHolder49 As Telerik.WinControls.UI.CommandBarStripInfoHolder = New Telerik.WinControls.UI.CommandBarStripInfoHolder
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm1))
        Dim CommandBarStripInfoHolder50 As Telerik.WinControls.UI.CommandBarStripInfoHolder = New Telerik.WinControls.UI.CommandBarStripInfoHolder
        Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip
        Me.radCommandBarElement1 = New Telerik.WinControls.UI.RadCommandBarElement
        Me.radCommandBarButton1 = New Telerik.WinControls.UI.CommandBarButton
        Me.radButtonElement3 = New Telerik.WinControls.UI.RadButtonElement
        Me.cbCultures = New Telerik.WinControls.UI.RadDropDownListElement
        Me.cbRightToLeft = New Telerik.WinControls.UI.RadCheckBoxElement
        Me.radToolStripElement2 = New Telerik.WinControls.UI.RadCommandBarElement
        Me.radCommandBarButton2 = New Telerik.WinControls.UI.CommandBarButton
        Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement
        Me.cbDayNameFormat = New Telerik.WinControls.UI.RadDropDownListElement
        Me.radButtonElement2 = New Telerik.WinControls.UI.RadButtonElement
        Me.cbFirstDayOfWeek = New Telerik.WinControls.UI.RadDropDownListElement
        Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar
        Me.object_39cedc8c_86c7_4053_9486_93a332de1676 = New Telerik.WinControls.RootRadElement
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.CommandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel
        Me.CommandBarDropDownList1 = New Telerik.WinControls.UI.CommandBarDropDownList
        Me.radCommandBar1 = New Telerik.WinControls.UI.RadCommandBar
        Me.CommandBarToggleButton1 = New Telerik.WinControls.UI.CommandBarToggleButton
        Me.CommandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement
        Me.CommandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement
        Me.CommandBarLabel2 = New Telerik.WinControls.UI.CommandBarLabel
        Me.CommandBarDropDownList2 = New Telerik.WinControls.UI.CommandBarDropDownList
        Me.CommandBarLabel3 = New Telerik.WinControls.UI.CommandBarLabel
        Me.CommandBarDropDownList3 = New Telerik.WinControls.UI.CommandBarDropDownList
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCultures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDayNameFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFirstDayOfWeek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radStatusStrip1
        '
        Me.radStatusStrip1.AutoSize = True
        Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1})
        Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
        Me.radStatusStrip1.Location = New System.Drawing.Point(0, 295)
        Me.radStatusStrip1.Name = "radStatusStrip1"
        Me.radStatusStrip1.Size = New System.Drawing.Size(576, 26)
        Me.radStatusStrip1.SizingGrip = False
        Me.radStatusStrip1.TabIndex = 1
        Me.radStatusStrip1.Text = "radStatusStrip1"
        '
        'radCommandBarElement1
        '
        Me.radCommandBarElement1.DisplayName = Nothing
        Me.radCommandBarElement1.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.radCommandBarElement1.MinSize = New System.Drawing.Size(0, 21)
        Me.radCommandBarElement1.Name = "radCommandBarElement1"
        Me.radCommandBarElement1.StripInfoHolder = CommandBarStripInfoHolder49
        Me.radCommandBarElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radCommandBarButton1
        '
        Me.radCommandBarButton1.AccessibleDescription = "radCommandBarButton1"
        Me.radCommandBarButton1.AccessibleName = "radCommandBarButton1"
        Me.radCommandBarButton1.Class = "ToolStripItem"
        Me.radCommandBarButton1.DisplayName = Nothing
        Me.radCommandBarButton1.Image = CType(resources.GetObject("radCommandBarButton1.Image"), System.Drawing.Image)
        Me.radCommandBarButton1.MinSize = New System.Drawing.Size(25, 21)
        Me.radCommandBarButton1.Name = "radCommandBarButton1"
        Me.radCommandBarButton1.Text = "radCommandBarButton1"
        Me.radCommandBarButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.radCommandBarButton1.VisibleInOverflowMenu = True
        '
        'radButtonElement3
        '
        Me.radButtonElement3.AccessibleDescription = "Culture:"
        Me.radButtonElement3.AccessibleName = "Culture:"
        Me.radButtonElement3.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.radButtonElement3.CanFocus = True
        Me.radButtonElement3.Enabled = False
        Me.radButtonElement3.Name = "radButtonElement3"
        Me.radButtonElement3.ShowBorder = False
        Me.radButtonElement3.Text = "Culture:"
        Me.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'cbCultures
        '
        Me.cbCultures.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbCultures.AutoCompleteAppend = Nothing
        Me.cbCultures.AutoCompleteDataSource = Nothing
        Me.cbCultures.AutoCompleteDisplayMember = Nothing
        Me.cbCultures.AutoCompleteSuggest = Nothing
        Me.cbCultures.AutoCompleteValueMember = Nothing
        Me.cbCultures.DataSource = Nothing
        Me.cbCultures.DefaultItemsCountInDropDown = 6
        Me.cbCultures.DefaultValue = Nothing
        Me.cbCultures.DisplayMember = ""
        Me.cbCultures.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad
        Me.cbCultures.EditableElementText = ""
        Me.cbCultures.EditorElement = Me.cbCultures
        Me.cbCultures.EditorManager = Nothing
        Me.cbCultures.Filter = Nothing
        Me.cbCultures.FilterExpression = ""
        Me.cbCultures.Focusable = True
        Me.cbCultures.FormatInfo = New System.Globalization.CultureInfo("en-US")
        Me.cbCultures.FormatString = ""
        Me.cbCultures.FormattingEnabled = True
        Me.cbCultures.ItemHeight = 18
        Me.cbCultures.MaxLength = 32767
        Me.cbCultures.MaxSize = New System.Drawing.Size(118, 20)
        Me.cbCultures.MaxValue = Nothing
        Me.cbCultures.MinSize = New System.Drawing.Size(118, 17)
        Me.cbCultures.MinValue = Nothing
        Me.cbCultures.Name = "cbCultures"
        Me.cbCultures.NullValue = Nothing
        Me.cbCultures.OwnerOffset = 0
        Me.cbCultures.ShowImageInEditorArea = True
        Me.cbCultures.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
        Me.cbCultures.Value = Nothing
        Me.cbCultures.ValueMember = ""
        Me.cbCultures.Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.cbCultures.GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).MinSize = New System.Drawing.Size(16, 0)
        '
        'cbRightToLeft
        '
        Me.cbRightToLeft.AccessibleDescription = "RightToLeft"
        Me.cbRightToLeft.AccessibleName = "RightToLeft"
        Me.cbRightToLeft.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbRightToLeft.CanFocus = True
        Me.cbRightToLeft.Checked = False
        Me.cbRightToLeft.Name = "cbRightToLeft"
        Me.cbRightToLeft.ShowBorder = False
        Me.cbRightToLeft.Text = "RightToLeft"
        Me.cbRightToLeft.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radToolStripElement2
        '
        Me.radToolStripElement2.DisplayName = Nothing
        Me.radToolStripElement2.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.radToolStripElement2.MinSize = New System.Drawing.Size(0, 21)
        Me.radToolStripElement2.Name = "radToolStripElement2"
        Me.radToolStripElement2.StripInfoHolder = CommandBarStripInfoHolder50
        Me.radToolStripElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'radCommandBarButton2
        '
        Me.radCommandBarButton2.AccessibleDescription = "radCommandBarButton2"
        Me.radCommandBarButton2.AccessibleName = "radCommandBarButton2"
        Me.radCommandBarButton2.Class = "ToolStripItem"
        Me.radCommandBarButton2.DisplayName = Nothing
        Me.radCommandBarButton2.Image = CType(resources.GetObject("radCommandBarButton2.Image"), System.Drawing.Image)
        Me.radCommandBarButton2.MinSize = New System.Drawing.Size(25, 21)
        Me.radCommandBarButton2.Name = "radCommandBarButton2"
        Me.radCommandBarButton2.Text = "radCommandBarButton2"
        Me.radCommandBarButton2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.radCommandBarButton2.VisibleInOverflowMenu = True
        '
        'radButtonElement1
        '
        Me.radButtonElement1.AccessibleDescription = "DayNameFormat:"
        Me.radButtonElement1.AccessibleName = "DayNameFormat:"
        Me.radButtonElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.radButtonElement1.CanFocus = True
        Me.radButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.radButtonElement1.Enabled = False
        Me.radButtonElement1.Name = "radButtonElement1"
        Me.radButtonElement1.ShowBorder = False
        Me.radButtonElement1.Text = "DayNameFormat:"
        Me.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'cbDayNameFormat
        '
        Me.cbDayNameFormat.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbDayNameFormat.AutoCompleteAppend = Nothing
        Me.cbDayNameFormat.AutoCompleteDataSource = Nothing
        Me.cbDayNameFormat.AutoCompleteDisplayMember = Nothing
        Me.cbDayNameFormat.AutoCompleteSuggest = Nothing
        Me.cbDayNameFormat.AutoCompleteValueMember = Nothing
        Me.cbDayNameFormat.DataSource = Nothing
        Me.cbDayNameFormat.DefaultItemsCountInDropDown = 6
        Me.cbDayNameFormat.DefaultValue = Nothing
        Me.cbDayNameFormat.DisplayMember = ""
        Me.cbDayNameFormat.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad
        Me.cbDayNameFormat.EditableElementText = ""
        Me.cbDayNameFormat.EditorElement = Me.cbDayNameFormat
        Me.cbDayNameFormat.EditorManager = Nothing
        Me.cbDayNameFormat.Filter = Nothing
        Me.cbDayNameFormat.FilterExpression = ""
        Me.cbDayNameFormat.Focusable = True
        Me.cbDayNameFormat.FormatInfo = New System.Globalization.CultureInfo("en-US")
        Me.cbDayNameFormat.FormatString = ""
        Me.cbDayNameFormat.FormattingEnabled = True
        Me.cbDayNameFormat.ItemHeight = 18
        Me.cbDayNameFormat.MaxLength = 32767
        Me.cbDayNameFormat.MaxSize = New System.Drawing.Size(118, 20)
        Me.cbDayNameFormat.MaxValue = Nothing
        Me.cbDayNameFormat.MinSize = New System.Drawing.Size(118, 17)
        Me.cbDayNameFormat.MinValue = Nothing
        Me.cbDayNameFormat.Name = "cbDayNameFormat"
        Me.cbDayNameFormat.NullValue = Nothing
        Me.cbDayNameFormat.OwnerOffset = 0
        Me.cbDayNameFormat.ShowImageInEditorArea = True
        Me.cbDayNameFormat.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
        Me.cbDayNameFormat.Value = Nothing
        Me.cbDayNameFormat.ValueMember = ""
        Me.cbDayNameFormat.Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.cbDayNameFormat.GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).MinSize = New System.Drawing.Size(16, 0)
        '
        'radButtonElement2
        '
        Me.radButtonElement2.AccessibleDescription = "FirstDayOfWeek:"
        Me.radButtonElement2.AccessibleName = "FirstDayOfWeek:"
        Me.radButtonElement2.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.radButtonElement2.CanFocus = True
        Me.radButtonElement2.Enabled = False
        Me.radButtonElement2.Name = "radButtonElement2"
        Me.radButtonElement2.ShowBorder = False
        Me.radButtonElement2.Text = "FirstDayOfWeek:"
        Me.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'cbFirstDayOfWeek
        '
        Me.cbFirstDayOfWeek.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbFirstDayOfWeek.AutoCompleteAppend = Nothing
        Me.cbFirstDayOfWeek.AutoCompleteDataSource = Nothing
        Me.cbFirstDayOfWeek.AutoCompleteDisplayMember = Nothing
        Me.cbFirstDayOfWeek.AutoCompleteSuggest = Nothing
        Me.cbFirstDayOfWeek.AutoCompleteValueMember = Nothing
        Me.cbFirstDayOfWeek.DataSource = Nothing
        Me.cbFirstDayOfWeek.DefaultItemsCountInDropDown = 6
        Me.cbFirstDayOfWeek.DefaultValue = Nothing
        Me.cbFirstDayOfWeek.DisplayMember = ""
        Me.cbFirstDayOfWeek.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad
        Me.cbFirstDayOfWeek.EditableElementText = ""
        Me.cbFirstDayOfWeek.EditorElement = Me.cbFirstDayOfWeek
        Me.cbFirstDayOfWeek.EditorManager = Nothing
        Me.cbFirstDayOfWeek.Filter = Nothing
        Me.cbFirstDayOfWeek.FilterExpression = ""
        Me.cbFirstDayOfWeek.Focusable = True
        Me.cbFirstDayOfWeek.FormatInfo = New System.Globalization.CultureInfo("en-US")
        Me.cbFirstDayOfWeek.FormatString = ""
        Me.cbFirstDayOfWeek.FormattingEnabled = True
        Me.cbFirstDayOfWeek.ItemHeight = 18
        Me.cbFirstDayOfWeek.MaxLength = 32767
        Me.cbFirstDayOfWeek.MaxSize = New System.Drawing.Size(118, 20)
        Me.cbFirstDayOfWeek.MaxValue = Nothing
        Me.cbFirstDayOfWeek.MinSize = New System.Drawing.Size(118, 17)
        Me.cbFirstDayOfWeek.MinValue = Nothing
        Me.cbFirstDayOfWeek.Name = "cbFirstDayOfWeek"
        Me.cbFirstDayOfWeek.NullValue = Nothing
        Me.cbFirstDayOfWeek.OwnerOffset = 0
        Me.cbFirstDayOfWeek.ShowImageInEditorArea = True
        Me.cbFirstDayOfWeek.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
        Me.cbFirstDayOfWeek.Value = Nothing
        Me.cbFirstDayOfWeek.ValueMember = ""
        Me.cbFirstDayOfWeek.Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.cbFirstDayOfWeek.GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).MinSize = New System.Drawing.Size(16, 0)
        '
        'radCalendar1
        '
        Me.radCalendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radCalendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radCalendar1.FastNavigationNextImage = CType(resources.GetObject("radCalendar1.FastNavigationNextImage"), System.Drawing.Image)
        Me.radCalendar1.FastNavigationPrevImage = CType(resources.GetObject("radCalendar1.FastNavigationPrevImage"), System.Drawing.Image)
        Me.radCalendar1.HeaderHeight = 17
        Me.radCalendar1.HeaderWidth = 17
        Me.radCalendar1.Location = New System.Drawing.Point(0, 85)
        Me.radCalendar1.Name = "radCalendar1"
        Me.radCalendar1.NavigationNextImage = CType(resources.GetObject("radCalendar1.NavigationNextImage"), System.Drawing.Image)
        Me.radCalendar1.NavigationPrevImage = CType(resources.GetObject("radCalendar1.NavigationPrevImage"), System.Drawing.Image)
        Me.radCalendar1.NavigationPrevText = "Prev"
        Me.radCalendar1.RangeMaxDate = New Date(2099, 12, 30, 0, 0, 0, 0)
        Me.radCalendar1.Size = New System.Drawing.Size(576, 210)
        Me.radCalendar1.TabIndex = 0
        Me.radCalendar1.Text = "radCalendar1"
        Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
        Me.radCalendar1.ZoomFactor = 1.2!
        CType(Me.radCalendar1.GetChildAt(0), Telerik.WinControls.UI.RadCalendarElement).ZoomFactor = 1.2!
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.CalendarNavigationElement).Text = "February 2009"
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRepeatButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRepeatButtonElement).Text = "<"
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(3).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Class = "prevButton"
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(3).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(3).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.Transparent
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(3).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(8), Telerik.WinControls.UI.CalendarCellElement).ZoomFactor = 1.2!
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(8), Telerik.WinControls.UI.CalendarCellElement).SpecialDay = False
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(8), Telerik.WinControls.UI.CalendarCellElement).Image = Nothing
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(8), Telerik.WinControls.UI.CalendarCellElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(8), Telerik.WinControls.UI.CalendarCellElement).Text = "S"
        CType(Me.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(8), Telerik.WinControls.UI.CalendarCellElement).ZIndex = 8
        '
        'object_39cedc8c_86c7_4053_9486_93a332de1676
        '
        Me.object_39cedc8c_86c7_4053_9486_93a332de1676.Name = "object_39cedc8c_86c7_4053_9486_93a332de1676"
        Me.object_39cedc8c_86c7_4053_9486_93a332de1676.StretchHorizontally = True
        Me.object_39cedc8c_86c7_4053_9486_93a332de1676.StretchVertically = True
        Me.object_39cedc8c_86c7_4053_9486_93a332de1676.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
        Me.CommandBarRowElement1.BorderLeftShadowColor = System.Drawing.Color.Empty
        Me.CommandBarRowElement1.DisplayName = Nothing
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        Me.CommandBarRowElement1.Text = ""
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
        Me.CommandBarStripElement1.BorderLeftShadowColor = System.Drawing.Color.Empty
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.FloatingForm = Nothing
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarLabel1, Me.CommandBarDropDownList1, Me.CommandBarToggleButton1})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Text = ""
        '
        'CommandBarLabel1
        '
        Me.CommandBarLabel1.AccessibleDescription = "CommandBarLabel1"
        Me.CommandBarLabel1.AccessibleName = "CommandBarLabel1"
        Me.CommandBarLabel1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
        Me.CommandBarLabel1.BorderLeftShadowColor = System.Drawing.Color.Empty
        Me.CommandBarLabel1.DisplayName = "CommandBarLabel1"
        Me.CommandBarLabel1.Name = "CommandBarLabel1"
        Me.CommandBarLabel1.Text = "Culture: "
        Me.CommandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarLabel1.VisibleInOverflowMenu = True
        '
        'CommandBarDropDownList1
        '
        Me.CommandBarDropDownList1.AccessibleDescription = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.AccessibleName = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
        Me.CommandBarDropDownList1.BorderLeftShadowColor = System.Drawing.Color.Empty
        Me.CommandBarDropDownList1.DisplayName = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.Name = "CommandBarDropDownList1"
        Me.CommandBarDropDownList1.Text = ""
        Me.CommandBarDropDownList1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarDropDownList1.VisibleInOverflowMenu = True
        '
        'radCommandBar1
        '
        Me.radCommandBar1.AutoSize = True
        Me.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.radCommandBar1.MinimumSize = New System.Drawing.Size(5, 5)
        Me.radCommandBar1.Name = "radCommandBar1"
        '
        '
        '
        Me.radCommandBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.radCommandBar1.RootElement.MinSize = New System.Drawing.Size(5, 5)
        Me.radCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1, Me.CommandBarRowElement2})
        Me.radCommandBar1.Size = New System.Drawing.Size(576, 85)
        Me.radCommandBar1.TabIndex = 2
        Me.radCommandBar1.Text = "radCommandBar1"
        '
        'CommandBarToggleButton1
        '
        Me.CommandBarToggleButton1.AccessibleDescription = "RightToLeft"
        Me.CommandBarToggleButton1.AccessibleName = "RightToLeft"
        Me.CommandBarToggleButton1.DisplayName = "CommandBarToggleButton1"
        Me.CommandBarToggleButton1.DrawText = True
        Me.CommandBarToggleButton1.Image = Nothing
        Me.CommandBarToggleButton1.Name = "CommandBarToggleButton1"
        Me.CommandBarToggleButton1.Text = "RightToLeft"
        Me.CommandBarToggleButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarToggleButton1.VisibleInOverflowMenu = True
        '
        'CommandBarRowElement2
        '
        Me.CommandBarRowElement2.DisplayName = Nothing
        Me.CommandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement2})
        '
        'CommandBarStripElement2
        '
        Me.CommandBarStripElement2.DisplayName = "CommandBarStripElement2"
        Me.CommandBarStripElement2.FloatingForm = Nothing
        Me.CommandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarLabel2, Me.CommandBarDropDownList2, Me.CommandBarLabel3, Me.CommandBarDropDownList3})
        Me.CommandBarStripElement2.Name = "CommandBarStripElement2"
        Me.CommandBarStripElement2.Text = ""
        '
        'CommandBarLabel2
        '
        Me.CommandBarLabel2.AccessibleDescription = "DayNameFormat"
        Me.CommandBarLabel2.AccessibleName = "DayNameFormat"
        Me.CommandBarLabel2.DisplayName = "CommandBarLabel2"
        Me.CommandBarLabel2.Name = "CommandBarLabel2"
        Me.CommandBarLabel2.Text = "DayNameFormat"
        Me.CommandBarLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarLabel2.VisibleInOverflowMenu = True
        '
        'CommandBarDropDownList2
        '
        Me.CommandBarDropDownList2.DisplayName = "CommandBarDropDownList2"
        Me.CommandBarDropDownList2.Name = "CommandBarDropDownList2"
        Me.CommandBarDropDownList2.Text = ""
        Me.CommandBarDropDownList2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarDropDownList2.VisibleInOverflowMenu = True
        '
        'CommandBarLabel3
        '
        Me.CommandBarLabel3.AccessibleDescription = "FirstDayOfWeek"
        Me.CommandBarLabel3.AccessibleName = "FirstDayOfWeek"
        Me.CommandBarLabel3.DisplayName = "CommandBarLabel3"
        Me.CommandBarLabel3.Name = "CommandBarLabel3"
        Me.CommandBarLabel3.Text = "FirstDayOfWeek"
        Me.CommandBarLabel3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarLabel3.VisibleInOverflowMenu = True
        '
        'CommandBarDropDownList3
        '
        Me.CommandBarDropDownList3.DisplayName = "CommandBarDropDownList3"
        Me.CommandBarDropDownList3.Name = "CommandBarDropDownList3"
        Me.CommandBarDropDownList3.Text = ""
        Me.CommandBarDropDownList3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarDropDownList3.VisibleInOverflowMenu = True
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadLabelElement1.TextWrap = True
        Me.RadLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 321)
        Me.Controls.Add(Me.radCalendar1)
        Me.Controls.Add(Me.radCommandBar1)
        Me.Controls.Add(Me.radStatusStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Globalization"
        CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCultures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDayNameFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFirstDayOfWeek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private radCommandBarElement1 As Telerik.WinControls.UI.RadCommandBarElement
    Private radCommandBarButton1 As Telerik.WinControls.UI.CommandBarButton
    Private WithEvents cbRightToLeft As Telerik.WinControls.UI.RadCheckBoxElement
    Private radToolStripElement2 As Telerik.WinControls.UI.RadCommandBarElement
    Private radCommandBarButton2 As Telerik.WinControls.UI.CommandBarButton
    Private WithEvents cbDayNameFormat As Telerik.WinControls.UI.RadDropDownListElement
    Private WithEvents cbFirstDayOfWeek As Telerik.WinControls.UI.RadDropDownListElement
    Private WithEvents cbCultures As Telerik.WinControls.UI.RadDropDownListElement
    Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
    Private radButtonElement2 As Telerik.WinControls.UI.RadButtonElement
    Private radButtonElement3 As Telerik.WinControls.UI.RadButtonElement
    Private object_39cedc8c_86c7_4053_9486_93a332de1676 As Telerik.WinControls.RootRadElement
    Private WithEvents radCalendar1 As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarLabel1 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents CommandBarDropDownList1 As Telerik.WinControls.UI.CommandBarDropDownList
    Private WithEvents radCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarToggleButton1 As Telerik.WinControls.UI.CommandBarToggleButton
    Friend WithEvents CommandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarLabel2 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents CommandBarDropDownList2 As Telerik.WinControls.UI.CommandBarDropDownList
    Friend WithEvents CommandBarLabel3 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents CommandBarDropDownList3 As Telerik.WinControls.UI.CommandBarDropDownList
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
End Class
