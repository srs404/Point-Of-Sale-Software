<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ordrtoday = New System.Windows.Forms.TextBox()
        Me.totordercount = New System.Windows.Forms.TextBox()
        Me.orderlabel = New System.Windows.Forms.Label()
        Me.todaydate = New System.Windows.Forms.TextBox()
        Me.LiqfinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Liqdbase = New Touch_Invoice.liqdbase()
        Me.orderno = New System.Windows.Forms.TextBox()
        Me.Refreshbutton = New System.Windows.Forms.Button()
        Me.toggledbase = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.iceteaclick = New System.Windows.Forms.Button()
        Me.juiceclick = New System.Windows.Forms.Button()
        Me.premiumchilclick = New System.Windows.Forms.Button()
        Me.mocktailclick = New System.Windows.Forms.Button()
        Me.lassiclick = New System.Windows.Forms.Button()
        Me.lemonclick = New System.Windows.Forms.Button()
        Me.milkshakeclick = New System.Windows.Forms.Button()
        Me.crusherclick = New System.Windows.Forms.Button()
        Me.coldcofclick = New System.Windows.Forms.Button()
        Me.hotcofclick = New System.Windows.Forms.Button()
        Me.dbidtext = New System.Windows.Forms.TextBox()
        Me.orderquant = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.vanillalattecount = New System.Windows.Forms.TextBox()
        Me.caramelmaccount = New System.Windows.Forms.TextBox()
        Me.blackcount = New System.Windows.Forms.TextBox()
        Me.mochacount = New System.Windows.Forms.TextBox()
        Me.lattecount = New System.Windows.Forms.TextBox()
        Me.cuppucount = New System.Windows.Forms.TextBox()
        Me.hazelnutlattecount = New System.Windows.Forms.TextBox()
        Me.h7lab = New System.Windows.Forms.Label()
        Me.h6lab = New System.Windows.Forms.Label()
        Me.hazelnutlatteadd = New System.Windows.Forms.Button()
        Me.h5lab = New System.Windows.Forms.Label()
        Me.vanilalatteadd = New System.Windows.Forms.Button()
        Me.caramelmacadd = New System.Windows.Forms.Button()
        Me.h4lab = New System.Windows.Forms.Label()
        Me.blackadd = New System.Windows.Forms.Button()
        Me.h3lab = New System.Windows.Forms.Label()
        Me.hazelnutlatterem = New System.Windows.Forms.Button()
        Me.mochaadd = New System.Windows.Forms.Button()
        Me.vanillalatterem = New System.Windows.Forms.Button()
        Me.caramelmacrem = New System.Windows.Forms.Button()
        Me.h2lab = New System.Windows.Forms.Label()
        Me.blackrem = New System.Windows.Forms.Button()
        Me.latteadd = New System.Windows.Forms.Button()
        Me.mocharem = New System.Windows.Forms.Button()
        Me.h1lab = New System.Windows.Forms.Label()
        Me.latterem = New System.Windows.Forms.Button()
        Me.cuppuadd = New System.Windows.Forms.Button()
        Me.cuppurem = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.caramelcoldcofcount = New System.Windows.Forms.TextBox()
        Me.vanillacoldcofcount = New System.Windows.Forms.TextBox()
        Me.chococoldcofcount = New System.Windows.Forms.TextBox()
        Me.coldcofcount = New System.Windows.Forms.TextBox()
        Me.c4lab = New System.Windows.Forms.Label()
        Me.c3lab = New System.Windows.Forms.Label()
        Me.c2lab = New System.Windows.Forms.Label()
        Me.c1lab = New System.Windows.Forms.Label()
        Me.caramelcoldcofadd = New System.Windows.Forms.Button()
        Me.vanillacoldcofadd = New System.Windows.Forms.Button()
        Me.chococoldcofadd = New System.Windows.Forms.Button()
        Me.coldcofadd = New System.Windows.Forms.Button()
        Me.caramelcoldcofrem = New System.Windows.Forms.Button()
        Me.vanillacoldcofrem = New System.Windows.Forms.Button()
        Me.chococoldcofrem = New System.Windows.Forms.Button()
        Me.coldcofrem = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ferrerocount = New System.Windows.Forms.TextBox()
        Me.r5lab = New System.Windows.Forms.Label()
        Me.darkchococount = New System.Windows.Forms.TextBox()
        Me.r4lab = New System.Windows.Forms.Label()
        Me.kitkatcount = New System.Windows.Forms.TextBox()
        Me.r3lab = New System.Windows.Forms.Label()
        Me.ferreroadd = New System.Windows.Forms.Button()
        Me.snickerscount = New System.Windows.Forms.TextBox()
        Me.darkchocoadd = New System.Windows.Forms.Button()
        Me.r2lab = New System.Windows.Forms.Label()
        Me.kitkatadd = New System.Windows.Forms.Button()
        Me.ferrerorem = New System.Windows.Forms.Button()
        Me.oreocount = New System.Windows.Forms.TextBox()
        Me.darkchocorem = New System.Windows.Forms.Button()
        Me.snickersadd = New System.Windows.Forms.Button()
        Me.kitkatrem = New System.Windows.Forms.Button()
        Me.r1lab = New System.Windows.Forms.Label()
        Me.snickersrem = New System.Windows.Forms.Button()
        Me.oreoadd = New System.Windows.Forms.Button()
        Me.oreorem = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.peanutbuttermilkcount = New System.Windows.Forms.TextBox()
        Me.bananamilkcount = New System.Windows.Forms.TextBox()
        Me.strawberrymilkcount = New System.Windows.Forms.TextBox()
        Me.mangomilkcount = New System.Windows.Forms.TextBox()
        Me.chocomilkcount = New System.Windows.Forms.TextBox()
        Me.vanillamilkcount = New System.Windows.Forms.TextBox()
        Me.m6lab = New System.Windows.Forms.Label()
        Me.peanutbuttermilkadd = New System.Windows.Forms.Button()
        Me.m5lab = New System.Windows.Forms.Label()
        Me.bananamilkadd = New System.Windows.Forms.Button()
        Me.m4lab = New System.Windows.Forms.Label()
        Me.strawberrymilkadd = New System.Windows.Forms.Button()
        Me.m3lab = New System.Windows.Forms.Label()
        Me.peanutbuttermilkrem = New System.Windows.Forms.Button()
        Me.mangomilkadd = New System.Windows.Forms.Button()
        Me.bananamilkrem = New System.Windows.Forms.Button()
        Me.m2lab = New System.Windows.Forms.Label()
        Me.strawberrymilkrem = New System.Windows.Forms.Button()
        Me.chocomilkadd = New System.Windows.Forms.Button()
        Me.mangomilkrem = New System.Windows.Forms.Button()
        Me.m1lab = New System.Windows.Forms.Label()
        Me.chocomilkrem = New System.Windows.Forms.Button()
        Me.vanillamilkadd = New System.Windows.Forms.Button()
        Me.vanillamilkrem = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.orangelemoncount = New System.Windows.Forms.TextBox()
        Me.lemonmojitocount = New System.Windows.Forms.TextBox()
        Me.n2lab = New System.Windows.Forms.Label()
        Me.orangelemonadd = New System.Windows.Forms.Button()
        Me.n1lab = New System.Windows.Forms.Label()
        Me.orangelemonrem = New System.Windows.Forms.Button()
        Me.lemonmojitoadd = New System.Windows.Forms.Button()
        Me.lemonmojitorem = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.mangolassicount = New System.Windows.Forms.TextBox()
        Me.espressolassicount = New System.Windows.Forms.TextBox()
        Me.lassicount = New System.Windows.Forms.TextBox()
        Me.l3lab = New System.Windows.Forms.Label()
        Me.mangolassiadd = New System.Windows.Forms.Button()
        Me.l2lab = New System.Windows.Forms.Label()
        Me.espressolassiadd = New System.Windows.Forms.Button()
        Me.mangolassirem = New System.Windows.Forms.Button()
        Me.l1lab = New System.Windows.Forms.Label()
        Me.espressolassirem = New System.Windows.Forms.Button()
        Me.lassiadd = New System.Windows.Forms.Button()
        Me.lassirem = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.darkcurrantcount = New System.Windows.Forms.TextBox()
        Me.yellowpunchcount = New System.Windows.Forms.TextBox()
        Me.bluebersparkcount = New System.Windows.Forms.TextBox()
        Me.grapeinvadecount = New System.Windows.Forms.TextBox()
        Me.virapplecount = New System.Windows.Forms.TextBox()
        Me.virsangriacount = New System.Windows.Forms.TextBox()
        Me.virsanfrancount = New System.Windows.Forms.TextBox()
        Me.k7lab = New System.Windows.Forms.Label()
        Me.darkcurrantadd = New System.Windows.Forms.Button()
        Me.k6lab = New System.Windows.Forms.Label()
        Me.yellowpunchadd = New System.Windows.Forms.Button()
        Me.k5lab = New System.Windows.Forms.Label()
        Me.bluebersparkadd = New System.Windows.Forms.Button()
        Me.k4lab = New System.Windows.Forms.Label()
        Me.grapeinvadeadd = New System.Windows.Forms.Button()
        Me.darkcurrantrem = New System.Windows.Forms.Button()
        Me.k3lab = New System.Windows.Forms.Label()
        Me.yellowpunchrem = New System.Windows.Forms.Button()
        Me.virappleadd = New System.Windows.Forms.Button()
        Me.bluebersparkrem = New System.Windows.Forms.Button()
        Me.k2lab = New System.Windows.Forms.Label()
        Me.grapeinvaderem = New System.Windows.Forms.Button()
        Me.virsangriaadd = New System.Windows.Forms.Button()
        Me.virapplerem = New System.Windows.Forms.Button()
        Me.k1lab = New System.Windows.Forms.Label()
        Me.virsangriarem = New System.Windows.Forms.Button()
        Me.virsanfranadd = New System.Windows.Forms.Button()
        Me.virsanfranrem = New System.Windows.Forms.Button()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.peanutchilcount = New System.Windows.Forms.TextBox()
        Me.hazelchilcofcount = New System.Windows.Forms.TextBox()
        Me.caramelchilcofcount = New System.Windows.Forms.TextBox()
        Me.chocochilcofcount = New System.Windows.Forms.TextBox()
        Me.p4lab = New System.Windows.Forms.Label()
        Me.peanutchilcofadd = New System.Windows.Forms.Button()
        Me.p3lab = New System.Windows.Forms.Label()
        Me.hazelchilcofadd = New System.Windows.Forms.Button()
        Me.p2lab = New System.Windows.Forms.Label()
        Me.peanutchilrem = New System.Windows.Forms.Button()
        Me.caramelchilcofadd = New System.Windows.Forms.Button()
        Me.hazelchilcofrem = New System.Windows.Forms.Button()
        Me.p1lab = New System.Windows.Forms.Label()
        Me.caramelchilcofrem = New System.Windows.Forms.Button()
        Me.chocochilcofadd = New System.Windows.Forms.Button()
        Me.chocochilcofrem = New System.Windows.Forms.Button()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.raspicedteacount = New System.Windows.Forms.TextBox()
        Me.strawicedteacount = New System.Windows.Forms.TextBox()
        Me.berryicedteacount = New System.Windows.Forms.TextBox()
        Me.t3lab = New System.Windows.Forms.Label()
        Me.raspicedteaadd = New System.Windows.Forms.Button()
        Me.t2lab = New System.Windows.Forms.Label()
        Me.strawicedteaadd = New System.Windows.Forms.Button()
        Me.raspicedtearem = New System.Windows.Forms.Button()
        Me.t1lab = New System.Windows.Forms.Label()
        Me.strawicedtearem = New System.Windows.Forms.Button()
        Me.berryicedteaadd = New System.Windows.Forms.Button()
        Me.berryicedtearem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.uicashback = New System.Windows.Forms.TextBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.duechecked = New System.Windows.Forms.TextBox()
        Me.duetextbox = New System.Windows.Forms.TextBox()
        Me.due = New System.Windows.Forms.CheckBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.uicashrec = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.uigrandtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.uidiscount = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.uitotalprice = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prevorderdb = New System.Windows.Forms.Button()
        Me.neworderbut = New System.Windows.Forms.Button()
        Me.countformtimer = New System.Windows.Forms.Timer(Me.components)
        Me.updateuiinfo = New System.Windows.Forms.Timer(Me.components)
        Me.listviewupdate = New System.Windows.Forms.Timer(Me.components)
        Me.LiqfinalTableAdapter = New Touch_Invoice.liqdbaseTableAdapters.liqfinalTableAdapter()
        Me.TableAdapterManager = New Touch_Invoice.liqdbaseTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalorderbutton = New System.Windows.Forms.Button()
        Me.fromdate = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DbfinalDataGridView = New System.Windows.Forms.DataGridView()
        Me.OrderQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T3dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T2dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T1dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P4dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P3dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P2dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P1dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R5dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R4dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N2dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M6dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M5dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M4dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M3dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M2dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M1dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K7dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K6dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K5dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K4dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K3dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K2dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K1dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L3dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L2dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L1dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C1dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H7dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H6dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H5dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H4dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H3dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H2dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H1dbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashBackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashRecievedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrandTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dbsearchbox = New System.Windows.Forms.TextBox()
        Me.recpt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LiqfinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Liqdbase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DbfinalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.ordrtoday)
        Me.GroupBox1.Controls.Add(Me.totordercount)
        Me.GroupBox1.Controls.Add(Me.orderlabel)
        Me.GroupBox1.Controls.Add(Me.todaydate)
        Me.GroupBox1.Controls.Add(Me.orderno)
        Me.GroupBox1.Controls.Add(Me.Refreshbutton)
        Me.GroupBox1.Controls.Add(Me.toggledbase)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.iceteaclick)
        Me.GroupBox1.Controls.Add(Me.juiceclick)
        Me.GroupBox1.Controls.Add(Me.premiumchilclick)
        Me.GroupBox1.Controls.Add(Me.mocktailclick)
        Me.GroupBox1.Controls.Add(Me.lassiclick)
        Me.GroupBox1.Controls.Add(Me.lemonclick)
        Me.GroupBox1.Controls.Add(Me.milkshakeclick)
        Me.GroupBox1.Controls.Add(Me.crusherclick)
        Me.GroupBox1.Controls.Add(Me.coldcofclick)
        Me.GroupBox1.Controls.Add(Me.hotcofclick)
        Me.GroupBox1.Controls.Add(Me.dbidtext)
        Me.GroupBox1.Controls.Add(Me.orderquant)
        Me.GroupBox1.Location = New System.Drawing.Point(1574, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 1064)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catagories"
        '
        'ordrtoday
        '
        Me.ordrtoday.BackColor = System.Drawing.Color.Black
        Me.ordrtoday.Cursor = System.Windows.Forms.Cursors.No
        Me.ordrtoday.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ordrtoday.ForeColor = System.Drawing.Color.White
        Me.ordrtoday.Location = New System.Drawing.Point(194, 147)
        Me.ordrtoday.Name = "ordrtoday"
        Me.ordrtoday.ReadOnly = True
        Me.ordrtoday.Size = New System.Drawing.Size(143, 36)
        Me.ordrtoday.TabIndex = 10007
        Me.ordrtoday.Text = "Order Today"
        Me.ordrtoday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ordrtoday.Visible = False
        '
        'totordercount
        '
        Me.totordercount.BackColor = System.Drawing.SystemColors.ControlDark
        Me.totordercount.Cursor = System.Windows.Forms.Cursors.No
        Me.totordercount.Font = New System.Drawing.Font("Unispace", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totordercount.ForeColor = System.Drawing.Color.White
        Me.totordercount.Location = New System.Drawing.Point(194, 61)
        Me.totordercount.Name = "totordercount"
        Me.totordercount.ReadOnly = True
        Me.totordercount.Size = New System.Drawing.Size(143, 88)
        Me.totordercount.TabIndex = 10006
        Me.totordercount.Text = "0"
        Me.totordercount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.totordercount.Visible = False
        '
        'orderlabel
        '
        Me.orderlabel.AutoSize = True
        Me.orderlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderlabel.Location = New System.Drawing.Point(95, 29)
        Me.orderlabel.Name = "orderlabel"
        Me.orderlabel.Size = New System.Drawing.Size(147, 29)
        Me.orderlabel.TabIndex = 10002
        Me.orderlabel.Text = "Order Desk"
        '
        'todaydate
        '
        Me.todaydate.BackColor = System.Drawing.Color.Black
        Me.todaydate.Cursor = System.Windows.Forms.Cursors.No
        Me.todaydate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "OrderDate", True))
        Me.todaydate.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todaydate.ForeColor = System.Drawing.Color.White
        Me.todaydate.Location = New System.Drawing.Point(100, 147)
        Me.todaydate.Name = "todaydate"
        Me.todaydate.ReadOnly = True
        Me.todaydate.Size = New System.Drawing.Size(132, 36)
        Me.todaydate.TabIndex = 37
        Me.todaydate.Text = "Order Now"
        Me.todaydate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LiqfinalBindingSource
        '
        Me.LiqfinalBindingSource.DataMember = "liqfinal"
        Me.LiqfinalBindingSource.DataSource = Me.Liqdbase
        '
        'Liqdbase
        '
        Me.Liqdbase.DataSetName = "liqdbase"
        Me.Liqdbase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'orderno
        '
        Me.orderno.BackColor = System.Drawing.SystemColors.ControlDark
        Me.orderno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "OrderNumber", True))
        Me.orderno.Font = New System.Drawing.Font("Unispace", 40.2!, System.Drawing.FontStyle.Bold)
        Me.orderno.ForeColor = System.Drawing.Color.White
        Me.orderno.Location = New System.Drawing.Point(100, 61)
        Me.orderno.Name = "orderno"
        Me.orderno.Size = New System.Drawing.Size(132, 88)
        Me.orderno.TabIndex = 10003
        Me.orderno.Text = "0"
        Me.orderno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Refreshbutton
        '
        Me.Refreshbutton.BackColor = System.Drawing.Color.DodgerBlue
        Me.Refreshbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Refreshbutton.Font = New System.Drawing.Font("Unispace", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refreshbutton.ForeColor = System.Drawing.Color.White
        Me.Refreshbutton.Location = New System.Drawing.Point(6, 1002)
        Me.Refreshbutton.Name = "Refreshbutton"
        Me.Refreshbutton.Size = New System.Drawing.Size(331, 52)
        Me.Refreshbutton.TabIndex = 10001
        Me.Refreshbutton.Text = "Current Order"
        Me.Refreshbutton.UseVisualStyleBackColor = False
        '
        'toggledbase
        '
        Me.toggledbase.BackColor = System.Drawing.Color.DarkCyan
        Me.toggledbase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.toggledbase.Font = New System.Drawing.Font("Unispace", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toggledbase.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.toggledbase.Location = New System.Drawing.Point(6, 934)
        Me.toggledbase.Name = "toggledbase"
        Me.toggledbase.Size = New System.Drawing.Size(331, 69)
        Me.toggledbase.TabIndex = 10001
        Me.toggledbase.Text = "Toggle Database"
        Me.toggledbase.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Red
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button11.FlatAppearance.BorderSize = 3
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(298, 12)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(39, 32)
        Me.Button11.TabIndex = 10000
        Me.Button11.Text = "X"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'iceteaclick
        '
        Me.iceteaclick.BackColor = System.Drawing.Color.Aquamarine
        Me.iceteaclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.iceteaclick.FlatAppearance.BorderSize = 2
        Me.iceteaclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.iceteaclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine
        Me.iceteaclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iceteaclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iceteaclick.Location = New System.Drawing.Point(6, 827)
        Me.iceteaclick.Name = "iceteaclick"
        Me.iceteaclick.Size = New System.Drawing.Size(331, 65)
        Me.iceteaclick.TabIndex = 10000
        Me.iceteaclick.Text = "Iced Tea"
        Me.iceteaclick.UseVisualStyleBackColor = False
        '
        'juiceclick
        '
        Me.juiceclick.BackColor = System.Drawing.Color.Orange
        Me.juiceclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.juiceclick.FlatAppearance.BorderSize = 2
        Me.juiceclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.juiceclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon
        Me.juiceclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.juiceclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.juiceclick.Location = New System.Drawing.Point(6, 989)
        Me.juiceclick.Name = "juiceclick"
        Me.juiceclick.Size = New System.Drawing.Size(331, 65)
        Me.juiceclick.TabIndex = 10000
        Me.juiceclick.Text = "Juice"
        Me.juiceclick.UseVisualStyleBackColor = False
        Me.juiceclick.Visible = False
        '
        'premiumchilclick
        '
        Me.premiumchilclick.BackColor = System.Drawing.Color.RoyalBlue
        Me.premiumchilclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.premiumchilclick.FlatAppearance.BorderSize = 2
        Me.premiumchilclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.premiumchilclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.premiumchilclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.premiumchilclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.premiumchilclick.Location = New System.Drawing.Point(6, 750)
        Me.premiumchilclick.Name = "premiumchilclick"
        Me.premiumchilclick.Size = New System.Drawing.Size(331, 65)
        Me.premiumchilclick.TabIndex = 10000
        Me.premiumchilclick.Text = "Premium Chilled Coffee"
        Me.premiumchilclick.UseVisualStyleBackColor = False
        '
        'mocktailclick
        '
        Me.mocktailclick.BackColor = System.Drawing.Color.DarkMagenta
        Me.mocktailclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.mocktailclick.FlatAppearance.BorderSize = 2
        Me.mocktailclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.mocktailclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta
        Me.mocktailclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mocktailclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mocktailclick.Location = New System.Drawing.Point(6, 673)
        Me.mocktailclick.Name = "mocktailclick"
        Me.mocktailclick.Size = New System.Drawing.Size(331, 65)
        Me.mocktailclick.TabIndex = 10000
        Me.mocktailclick.Text = "Mocktail"
        Me.mocktailclick.UseVisualStyleBackColor = False
        '
        'lassiclick
        '
        Me.lassiclick.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lassiclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.lassiclick.FlatAppearance.BorderSize = 2
        Me.lassiclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.lassiclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.lassiclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lassiclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lassiclick.Location = New System.Drawing.Point(6, 594)
        Me.lassiclick.Name = "lassiclick"
        Me.lassiclick.Size = New System.Drawing.Size(331, 65)
        Me.lassiclick.TabIndex = 10000
        Me.lassiclick.Text = "Lassi"
        Me.lassiclick.UseVisualStyleBackColor = False
        '
        'lemonclick
        '
        Me.lemonclick.BackColor = System.Drawing.Color.LimeGreen
        Me.lemonclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.lemonclick.FlatAppearance.BorderSize = 2
        Me.lemonclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.lemonclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.lemonclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lemonclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lemonclick.Location = New System.Drawing.Point(6, 510)
        Me.lemonclick.Name = "lemonclick"
        Me.lemonclick.Size = New System.Drawing.Size(331, 65)
        Me.lemonclick.TabIndex = 10000
        Me.lemonclick.Text = "Lemonade"
        Me.lemonclick.UseVisualStyleBackColor = False
        '
        'milkshakeclick
        '
        Me.milkshakeclick.BackColor = System.Drawing.Color.Peru
        Me.milkshakeclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.milkshakeclick.FlatAppearance.BorderSize = 2
        Me.milkshakeclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.milkshakeclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru
        Me.milkshakeclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.milkshakeclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.milkshakeclick.Location = New System.Drawing.Point(6, 430)
        Me.milkshakeclick.Name = "milkshakeclick"
        Me.milkshakeclick.Size = New System.Drawing.Size(331, 65)
        Me.milkshakeclick.TabIndex = 10000
        Me.milkshakeclick.Text = "Milk Shake"
        Me.milkshakeclick.UseVisualStyleBackColor = False
        '
        'crusherclick
        '
        Me.crusherclick.BackColor = System.Drawing.Color.Sienna
        Me.crusherclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.crusherclick.FlatAppearance.BorderSize = 2
        Me.crusherclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.crusherclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna
        Me.crusherclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crusherclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crusherclick.Location = New System.Drawing.Point(6, 349)
        Me.crusherclick.Name = "crusherclick"
        Me.crusherclick.Size = New System.Drawing.Size(331, 65)
        Me.crusherclick.TabIndex = 10000
        Me.crusherclick.Text = "Crushers"
        Me.crusherclick.UseVisualStyleBackColor = False
        '
        'coldcofclick
        '
        Me.coldcofclick.BackColor = System.Drawing.Color.PaleTurquoise
        Me.coldcofclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.coldcofclick.FlatAppearance.BorderSize = 2
        Me.coldcofclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.coldcofclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.coldcofclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coldcofclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coldcofclick.Location = New System.Drawing.Point(6, 269)
        Me.coldcofclick.Name = "coldcofclick"
        Me.coldcofclick.Size = New System.Drawing.Size(331, 65)
        Me.coldcofclick.TabIndex = 10000
        Me.coldcofclick.Text = "Cold Coffee"
        Me.coldcofclick.UseVisualStyleBackColor = False
        '
        'hotcofclick
        '
        Me.hotcofclick.BackColor = System.Drawing.Color.Red
        Me.hotcofclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.hotcofclick.FlatAppearance.BorderSize = 2
        Me.hotcofclick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.hotcofclick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.hotcofclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hotcofclick.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hotcofclick.Location = New System.Drawing.Point(6, 189)
        Me.hotcofclick.Name = "hotcofclick"
        Me.hotcofclick.Size = New System.Drawing.Size(331, 65)
        Me.hotcofclick.TabIndex = 10000
        Me.hotcofclick.Text = "Hot Coffee"
        Me.hotcofclick.UseVisualStyleBackColor = False
        '
        'dbidtext
        '
        Me.dbidtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dbidtext.Cursor = System.Windows.Forms.Cursors.No
        Me.dbidtext.Location = New System.Drawing.Point(113, 100)
        Me.dbidtext.Name = "dbidtext"
        Me.dbidtext.ReadOnly = True
        Me.dbidtext.Size = New System.Drawing.Size(22, 22)
        Me.dbidtext.TabIndex = 10004
        '
        'orderquant
        '
        Me.orderquant.Cursor = System.Windows.Forms.Cursors.No
        Me.orderquant.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "OrderQuantity", True))
        Me.orderquant.Location = New System.Drawing.Point(113, 119)
        Me.orderquant.Name = "orderquant"
        Me.orderquant.ReadOnly = True
        Me.orderquant.Size = New System.Drawing.Size(27, 22)
        Me.orderquant.TabIndex = 10005
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Location = New System.Drawing.Point(1157, -23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(411, 1101)
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.vanillalattecount)
        Me.TabPage1.Controls.Add(Me.caramelmaccount)
        Me.TabPage1.Controls.Add(Me.blackcount)
        Me.TabPage1.Controls.Add(Me.mochacount)
        Me.TabPage1.Controls.Add(Me.lattecount)
        Me.TabPage1.Controls.Add(Me.cuppucount)
        Me.TabPage1.Controls.Add(Me.hazelnutlattecount)
        Me.TabPage1.Controls.Add(Me.h7lab)
        Me.TabPage1.Controls.Add(Me.h6lab)
        Me.TabPage1.Controls.Add(Me.hazelnutlatteadd)
        Me.TabPage1.Controls.Add(Me.h5lab)
        Me.TabPage1.Controls.Add(Me.vanilalatteadd)
        Me.TabPage1.Controls.Add(Me.caramelmacadd)
        Me.TabPage1.Controls.Add(Me.h4lab)
        Me.TabPage1.Controls.Add(Me.blackadd)
        Me.TabPage1.Controls.Add(Me.h3lab)
        Me.TabPage1.Controls.Add(Me.hazelnutlatterem)
        Me.TabPage1.Controls.Add(Me.mochaadd)
        Me.TabPage1.Controls.Add(Me.vanillalatterem)
        Me.TabPage1.Controls.Add(Me.caramelmacrem)
        Me.TabPage1.Controls.Add(Me.h2lab)
        Me.TabPage1.Controls.Add(Me.blackrem)
        Me.TabPage1.Controls.Add(Me.latteadd)
        Me.TabPage1.Controls.Add(Me.mocharem)
        Me.TabPage1.Controls.Add(Me.h1lab)
        Me.TabPage1.Controls.Add(Me.latterem)
        Me.TabPage1.Controls.Add(Me.cuppuadd)
        Me.TabPage1.Controls.Add(Me.cuppurem)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Hot Coffee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'vanillalattecount
        '
        Me.vanillalattecount.Cursor = System.Windows.Forms.Cursors.No
        Me.vanillalattecount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "h6db", True))
        Me.vanillalattecount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.vanillalattecount.Location = New System.Drawing.Point(151, 709)
        Me.vanillalattecount.Name = "vanillalattecount"
        Me.vanillalattecount.ReadOnly = True
        Me.vanillalattecount.Size = New System.Drawing.Size(100, 64)
        Me.vanillalattecount.TabIndex = 34
        Me.vanillalattecount.Text = "0"
        Me.vanillalattecount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'caramelmaccount
        '
        Me.caramelmaccount.Cursor = System.Windows.Forms.Cursors.No
        Me.caramelmaccount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "h5db", True))
        Me.caramelmaccount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.caramelmaccount.Location = New System.Drawing.Point(151, 584)
        Me.caramelmaccount.Name = "caramelmaccount"
        Me.caramelmaccount.ReadOnly = True
        Me.caramelmaccount.Size = New System.Drawing.Size(100, 64)
        Me.caramelmaccount.TabIndex = 33
        Me.caramelmaccount.Text = "0"
        Me.caramelmaccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'blackcount
        '
        Me.blackcount.Cursor = System.Windows.Forms.Cursors.No
        Me.blackcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "h4db", True))
        Me.blackcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.blackcount.Location = New System.Drawing.Point(151, 458)
        Me.blackcount.Name = "blackcount"
        Me.blackcount.ReadOnly = True
        Me.blackcount.Size = New System.Drawing.Size(100, 64)
        Me.blackcount.TabIndex = 32
        Me.blackcount.Text = "0"
        Me.blackcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mochacount
        '
        Me.mochacount.Cursor = System.Windows.Forms.Cursors.No
        Me.mochacount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "h3db", True))
        Me.mochacount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.mochacount.Location = New System.Drawing.Point(151, 335)
        Me.mochacount.Name = "mochacount"
        Me.mochacount.ReadOnly = True
        Me.mochacount.Size = New System.Drawing.Size(100, 64)
        Me.mochacount.TabIndex = 31
        Me.mochacount.Text = "0"
        Me.mochacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lattecount
        '
        Me.lattecount.Cursor = System.Windows.Forms.Cursors.No
        Me.lattecount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "h2db", True))
        Me.lattecount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.lattecount.Location = New System.Drawing.Point(151, 207)
        Me.lattecount.Name = "lattecount"
        Me.lattecount.ReadOnly = True
        Me.lattecount.Size = New System.Drawing.Size(100, 64)
        Me.lattecount.TabIndex = 30
        Me.lattecount.Text = "0"
        Me.lattecount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cuppucount
        '
        Me.cuppucount.Cursor = System.Windows.Forms.Cursors.No
        Me.cuppucount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "h1db", True))
        Me.cuppucount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.cuppucount.Location = New System.Drawing.Point(151, 83)
        Me.cuppucount.Name = "cuppucount"
        Me.cuppucount.ReadOnly = True
        Me.cuppucount.Size = New System.Drawing.Size(100, 64)
        Me.cuppucount.TabIndex = 29
        Me.cuppucount.Text = "0"
        Me.cuppucount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hazelnutlattecount
        '
        Me.hazelnutlattecount.Cursor = System.Windows.Forms.Cursors.No
        Me.hazelnutlattecount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "h7db", True))
        Me.hazelnutlattecount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hazelnutlattecount.Location = New System.Drawing.Point(151, 839)
        Me.hazelnutlattecount.Name = "hazelnutlattecount"
        Me.hazelnutlattecount.ReadOnly = True
        Me.hazelnutlattecount.Size = New System.Drawing.Size(100, 64)
        Me.hazelnutlattecount.TabIndex = 2
        Me.hazelnutlattecount.Text = "0"
        Me.hazelnutlattecount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'h7lab
        '
        Me.h7lab.AutoSize = True
        Me.h7lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.h7lab.Location = New System.Drawing.Point(96, 783)
        Me.h7lab.Name = "h7lab"
        Me.h7lab.Size = New System.Drawing.Size(225, 52)
        Me.h7lab.TabIndex = 1
        Me.h7lab.Text = "Hazelnut Latte"
        '
        'h6lab
        '
        Me.h6lab.AutoSize = True
        Me.h6lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.h6lab.Location = New System.Drawing.Point(107, 653)
        Me.h6lab.Name = "h6lab"
        Me.h6lab.Size = New System.Drawing.Size(196, 52)
        Me.h6lab.TabIndex = 1
        Me.h6lab.Text = "Vanilla Latte"
        '
        'hazelnutlatteadd
        '
        Me.hazelnutlatteadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hazelnutlatteadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.hazelnutlatteadd.Location = New System.Drawing.Point(257, 839)
        Me.hazelnutlatteadd.Name = "hazelnutlatteadd"
        Me.hazelnutlatteadd.Size = New System.Drawing.Size(111, 64)
        Me.hazelnutlatteadd.TabIndex = 0
        Me.hazelnutlatteadd.Text = "+"
        Me.hazelnutlatteadd.UseVisualStyleBackColor = True
        '
        'h5lab
        '
        Me.h5lab.AutoSize = True
        Me.h5lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.h5lab.Location = New System.Drawing.Point(51, 528)
        Me.h5lab.Name = "h5lab"
        Me.h5lab.Size = New System.Drawing.Size(299, 52)
        Me.h5lab.TabIndex = 1
        Me.h5lab.Text = "Caramel Macchiato"
        '
        'vanilalatteadd
        '
        Me.vanilalatteadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vanilalatteadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.vanilalatteadd.Location = New System.Drawing.Point(257, 709)
        Me.vanilalatteadd.Name = "vanilalatteadd"
        Me.vanilalatteadd.Size = New System.Drawing.Size(111, 64)
        Me.vanilalatteadd.TabIndex = 0
        Me.vanilalatteadd.Text = "+"
        Me.vanilalatteadd.UseVisualStyleBackColor = True
        '
        'caramelmacadd
        '
        Me.caramelmacadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caramelmacadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.caramelmacadd.Location = New System.Drawing.Point(257, 584)
        Me.caramelmacadd.Name = "caramelmacadd"
        Me.caramelmacadd.Size = New System.Drawing.Size(111, 64)
        Me.caramelmacadd.TabIndex = 0
        Me.caramelmacadd.Text = "+"
        Me.caramelmacadd.UseVisualStyleBackColor = True
        '
        'h4lab
        '
        Me.h4lab.AutoSize = True
        Me.h4lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.h4lab.Location = New System.Drawing.Point(96, 402)
        Me.h4lab.Name = "h4lab"
        Me.h4lab.Size = New System.Drawing.Size(204, 52)
        Me.h4lab.TabIndex = 1
        Me.h4lab.Text = "Black Coffee"
        '
        'blackadd
        '
        Me.blackadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blackadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.blackadd.Location = New System.Drawing.Point(257, 458)
        Me.blackadd.Name = "blackadd"
        Me.blackadd.Size = New System.Drawing.Size(111, 64)
        Me.blackadd.TabIndex = 0
        Me.blackadd.Text = "+"
        Me.blackadd.UseVisualStyleBackColor = True
        '
        'h3lab
        '
        Me.h3lab.AutoSize = True
        Me.h3lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.h3lab.Location = New System.Drawing.Point(107, 279)
        Me.h3lab.Name = "h3lab"
        Me.h3lab.Size = New System.Drawing.Size(190, 52)
        Me.h3lab.TabIndex = 1
        Me.h3lab.Text = "Cafe Mocha"
        '
        'hazelnutlatterem
        '
        Me.hazelnutlatterem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hazelnutlatterem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.hazelnutlatterem.Location = New System.Drawing.Point(35, 839)
        Me.hazelnutlatterem.Name = "hazelnutlatterem"
        Me.hazelnutlatterem.Size = New System.Drawing.Size(111, 64)
        Me.hazelnutlatterem.TabIndex = 0
        Me.hazelnutlatterem.Text = "-"
        Me.hazelnutlatterem.UseVisualStyleBackColor = True
        '
        'mochaadd
        '
        Me.mochaadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mochaadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.mochaadd.Location = New System.Drawing.Point(257, 335)
        Me.mochaadd.Name = "mochaadd"
        Me.mochaadd.Size = New System.Drawing.Size(111, 64)
        Me.mochaadd.TabIndex = 0
        Me.mochaadd.Text = "+"
        Me.mochaadd.UseVisualStyleBackColor = True
        '
        'vanillalatterem
        '
        Me.vanillalatterem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vanillalatterem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.vanillalatterem.Location = New System.Drawing.Point(35, 709)
        Me.vanillalatterem.Name = "vanillalatterem"
        Me.vanillalatterem.Size = New System.Drawing.Size(111, 64)
        Me.vanillalatterem.TabIndex = 0
        Me.vanillalatterem.Text = "-"
        Me.vanillalatterem.UseVisualStyleBackColor = True
        '
        'caramelmacrem
        '
        Me.caramelmacrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caramelmacrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.caramelmacrem.Location = New System.Drawing.Point(35, 584)
        Me.caramelmacrem.Name = "caramelmacrem"
        Me.caramelmacrem.Size = New System.Drawing.Size(111, 64)
        Me.caramelmacrem.TabIndex = 0
        Me.caramelmacrem.Text = "-"
        Me.caramelmacrem.UseVisualStyleBackColor = True
        '
        'h2lab
        '
        Me.h2lab.AutoSize = True
        Me.h2lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.h2lab.Location = New System.Drawing.Point(113, 151)
        Me.h2lab.Name = "h2lab"
        Me.h2lab.Size = New System.Drawing.Size(170, 52)
        Me.h2lab.TabIndex = 1
        Me.h2lab.Text = "Cafe Latte"
        '
        'blackrem
        '
        Me.blackrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blackrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.blackrem.Location = New System.Drawing.Point(35, 458)
        Me.blackrem.Name = "blackrem"
        Me.blackrem.Size = New System.Drawing.Size(111, 64)
        Me.blackrem.TabIndex = 0
        Me.blackrem.Text = "-"
        Me.blackrem.UseVisualStyleBackColor = True
        '
        'latteadd
        '
        Me.latteadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.latteadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.latteadd.Location = New System.Drawing.Point(257, 207)
        Me.latteadd.Name = "latteadd"
        Me.latteadd.Size = New System.Drawing.Size(111, 64)
        Me.latteadd.TabIndex = 0
        Me.latteadd.Text = "+"
        Me.latteadd.UseVisualStyleBackColor = True
        '
        'mocharem
        '
        Me.mocharem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mocharem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.mocharem.Location = New System.Drawing.Point(35, 335)
        Me.mocharem.Name = "mocharem"
        Me.mocharem.Size = New System.Drawing.Size(111, 64)
        Me.mocharem.TabIndex = 0
        Me.mocharem.Text = "-"
        Me.mocharem.UseVisualStyleBackColor = True
        '
        'h1lab
        '
        Me.h1lab.AutoSize = True
        Me.h1lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.h1lab.Location = New System.Drawing.Point(107, 27)
        Me.h1lab.Name = "h1lab"
        Me.h1lab.Size = New System.Drawing.Size(187, 52)
        Me.h1lab.TabIndex = 1
        Me.h1lab.Text = "Cappuccino"
        '
        'latterem
        '
        Me.latterem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.latterem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold)
        Me.latterem.Location = New System.Drawing.Point(35, 207)
        Me.latterem.Name = "latterem"
        Me.latterem.Size = New System.Drawing.Size(111, 64)
        Me.latterem.TabIndex = 0
        Me.latterem.Text = "-"
        Me.latterem.UseVisualStyleBackColor = True
        '
        'cuppuadd
        '
        Me.cuppuadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cuppuadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuppuadd.Location = New System.Drawing.Point(257, 83)
        Me.cuppuadd.Name = "cuppuadd"
        Me.cuppuadd.Size = New System.Drawing.Size(111, 64)
        Me.cuppuadd.TabIndex = 0
        Me.cuppuadd.Text = "+"
        Me.cuppuadd.UseVisualStyleBackColor = True
        '
        'cuppurem
        '
        Me.cuppurem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cuppurem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuppurem.Location = New System.Drawing.Point(35, 83)
        Me.cuppurem.Name = "cuppurem"
        Me.cuppurem.Size = New System.Drawing.Size(111, 64)
        Me.cuppurem.TabIndex = 0
        Me.cuppurem.Text = "-"
        Me.cuppurem.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.caramelcoldcofcount)
        Me.TabPage2.Controls.Add(Me.vanillacoldcofcount)
        Me.TabPage2.Controls.Add(Me.chococoldcofcount)
        Me.TabPage2.Controls.Add(Me.coldcofcount)
        Me.TabPage2.Controls.Add(Me.c4lab)
        Me.TabPage2.Controls.Add(Me.c3lab)
        Me.TabPage2.Controls.Add(Me.c2lab)
        Me.TabPage2.Controls.Add(Me.c1lab)
        Me.TabPage2.Controls.Add(Me.caramelcoldcofadd)
        Me.TabPage2.Controls.Add(Me.vanillacoldcofadd)
        Me.TabPage2.Controls.Add(Me.chococoldcofadd)
        Me.TabPage2.Controls.Add(Me.coldcofadd)
        Me.TabPage2.Controls.Add(Me.caramelcoldcofrem)
        Me.TabPage2.Controls.Add(Me.vanillacoldcofrem)
        Me.TabPage2.Controls.Add(Me.chococoldcofrem)
        Me.TabPage2.Controls.Add(Me.coldcofrem)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cold Coffee"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'caramelcoldcofcount
        '
        Me.caramelcoldcofcount.Cursor = System.Windows.Forms.Cursors.No
        Me.caramelcoldcofcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "c4db", True))
        Me.caramelcoldcofcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caramelcoldcofcount.Location = New System.Drawing.Point(152, 614)
        Me.caramelcoldcofcount.Name = "caramelcoldcofcount"
        Me.caramelcoldcofcount.ReadOnly = True
        Me.caramelcoldcofcount.Size = New System.Drawing.Size(100, 64)
        Me.caramelcoldcofcount.TabIndex = 6
        Me.caramelcoldcofcount.Text = "0"
        Me.caramelcoldcofcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'vanillacoldcofcount
        '
        Me.vanillacoldcofcount.Cursor = System.Windows.Forms.Cursors.No
        Me.vanillacoldcofcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "c3db", True))
        Me.vanillacoldcofcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vanillacoldcofcount.Location = New System.Drawing.Point(152, 438)
        Me.vanillacoldcofcount.Name = "vanillacoldcofcount"
        Me.vanillacoldcofcount.ReadOnly = True
        Me.vanillacoldcofcount.Size = New System.Drawing.Size(100, 64)
        Me.vanillacoldcofcount.TabIndex = 6
        Me.vanillacoldcofcount.Text = "0"
        Me.vanillacoldcofcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chococoldcofcount
        '
        Me.chococoldcofcount.Cursor = System.Windows.Forms.Cursors.No
        Me.chococoldcofcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "c2db", True))
        Me.chococoldcofcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chococoldcofcount.Location = New System.Drawing.Point(152, 269)
        Me.chococoldcofcount.Name = "chococoldcofcount"
        Me.chococoldcofcount.ReadOnly = True
        Me.chococoldcofcount.Size = New System.Drawing.Size(100, 64)
        Me.chococoldcofcount.TabIndex = 6
        Me.chococoldcofcount.Text = "0"
        Me.chococoldcofcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'coldcofcount
        '
        Me.coldcofcount.Cursor = System.Windows.Forms.Cursors.No
        Me.coldcofcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "c1db", True))
        Me.coldcofcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coldcofcount.Location = New System.Drawing.Point(152, 109)
        Me.coldcofcount.Name = "coldcofcount"
        Me.coldcofcount.ReadOnly = True
        Me.coldcofcount.Size = New System.Drawing.Size(100, 64)
        Me.coldcofcount.TabIndex = 6
        Me.coldcofcount.Text = "0"
        Me.coldcofcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c4lab
        '
        Me.c4lab.AutoSize = True
        Me.c4lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.c4lab.Location = New System.Drawing.Point(48, 559)
        Me.c4lab.Name = "c4lab"
        Me.c4lab.Size = New System.Drawing.Size(319, 52)
        Me.c4lab.TabIndex = 5
        Me.c4lab.Text = "Caramel Cold Coffee"
        '
        'c3lab
        '
        Me.c3lab.AutoSize = True
        Me.c3lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.c3lab.Location = New System.Drawing.Point(48, 383)
        Me.c3lab.Name = "c3lab"
        Me.c3lab.Size = New System.Drawing.Size(290, 52)
        Me.c3lab.TabIndex = 5
        Me.c3lab.Text = "Vanilla Cold Coffee"
        '
        'c2lab
        '
        Me.c2lab.AutoSize = True
        Me.c2lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.c2lab.Location = New System.Drawing.Point(33, 214)
        Me.c2lab.Name = "c2lab"
        Me.c2lab.Size = New System.Drawing.Size(340, 52)
        Me.c2lab.TabIndex = 5
        Me.c2lab.Text = "Chocolate Cold Coffee"
        '
        'c1lab
        '
        Me.c1lab.AutoSize = True
        Me.c1lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold)
        Me.c1lab.Location = New System.Drawing.Point(48, 53)
        Me.c1lab.Name = "c1lab"
        Me.c1lab.Size = New System.Drawing.Size(310, 52)
        Me.c1lab.TabIndex = 5
        Me.c1lab.Text = "Cold Coffee Regular"
        '
        'caramelcoldcofadd
        '
        Me.caramelcoldcofadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caramelcoldcofadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caramelcoldcofadd.Location = New System.Drawing.Point(258, 614)
        Me.caramelcoldcofadd.Name = "caramelcoldcofadd"
        Me.caramelcoldcofadd.Size = New System.Drawing.Size(111, 64)
        Me.caramelcoldcofadd.TabIndex = 3
        Me.caramelcoldcofadd.Text = "+"
        Me.caramelcoldcofadd.UseVisualStyleBackColor = True
        '
        'vanillacoldcofadd
        '
        Me.vanillacoldcofadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vanillacoldcofadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vanillacoldcofadd.Location = New System.Drawing.Point(258, 438)
        Me.vanillacoldcofadd.Name = "vanillacoldcofadd"
        Me.vanillacoldcofadd.Size = New System.Drawing.Size(111, 64)
        Me.vanillacoldcofadd.TabIndex = 3
        Me.vanillacoldcofadd.Text = "+"
        Me.vanillacoldcofadd.UseVisualStyleBackColor = True
        '
        'chococoldcofadd
        '
        Me.chococoldcofadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chococoldcofadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chococoldcofadd.Location = New System.Drawing.Point(258, 269)
        Me.chococoldcofadd.Name = "chococoldcofadd"
        Me.chococoldcofadd.Size = New System.Drawing.Size(111, 64)
        Me.chococoldcofadd.TabIndex = 3
        Me.chococoldcofadd.Text = "+"
        Me.chococoldcofadd.UseVisualStyleBackColor = True
        '
        'coldcofadd
        '
        Me.coldcofadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coldcofadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coldcofadd.Location = New System.Drawing.Point(258, 109)
        Me.coldcofadd.Name = "coldcofadd"
        Me.coldcofadd.Size = New System.Drawing.Size(111, 64)
        Me.coldcofadd.TabIndex = 3
        Me.coldcofadd.Text = "+"
        Me.coldcofadd.UseVisualStyleBackColor = True
        '
        'caramelcoldcofrem
        '
        Me.caramelcoldcofrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caramelcoldcofrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caramelcoldcofrem.Location = New System.Drawing.Point(36, 614)
        Me.caramelcoldcofrem.Name = "caramelcoldcofrem"
        Me.caramelcoldcofrem.Size = New System.Drawing.Size(111, 64)
        Me.caramelcoldcofrem.TabIndex = 4
        Me.caramelcoldcofrem.Text = "-"
        Me.caramelcoldcofrem.UseVisualStyleBackColor = True
        '
        'vanillacoldcofrem
        '
        Me.vanillacoldcofrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vanillacoldcofrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vanillacoldcofrem.Location = New System.Drawing.Point(36, 438)
        Me.vanillacoldcofrem.Name = "vanillacoldcofrem"
        Me.vanillacoldcofrem.Size = New System.Drawing.Size(111, 64)
        Me.vanillacoldcofrem.TabIndex = 4
        Me.vanillacoldcofrem.Text = "-"
        Me.vanillacoldcofrem.UseVisualStyleBackColor = True
        '
        'chococoldcofrem
        '
        Me.chococoldcofrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chococoldcofrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chococoldcofrem.Location = New System.Drawing.Point(36, 269)
        Me.chococoldcofrem.Name = "chococoldcofrem"
        Me.chococoldcofrem.Size = New System.Drawing.Size(111, 64)
        Me.chococoldcofrem.TabIndex = 4
        Me.chococoldcofrem.Text = "-"
        Me.chococoldcofrem.UseVisualStyleBackColor = True
        '
        'coldcofrem
        '
        Me.coldcofrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coldcofrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coldcofrem.Location = New System.Drawing.Point(36, 109)
        Me.coldcofrem.Name = "coldcofrem"
        Me.coldcofrem.Size = New System.Drawing.Size(111, 64)
        Me.coldcofrem.TabIndex = 4
        Me.coldcofrem.Text = "-"
        Me.coldcofrem.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ferrerocount)
        Me.TabPage3.Controls.Add(Me.r5lab)
        Me.TabPage3.Controls.Add(Me.darkchococount)
        Me.TabPage3.Controls.Add(Me.r4lab)
        Me.TabPage3.Controls.Add(Me.kitkatcount)
        Me.TabPage3.Controls.Add(Me.r3lab)
        Me.TabPage3.Controls.Add(Me.ferreroadd)
        Me.TabPage3.Controls.Add(Me.snickerscount)
        Me.TabPage3.Controls.Add(Me.darkchocoadd)
        Me.TabPage3.Controls.Add(Me.r2lab)
        Me.TabPage3.Controls.Add(Me.kitkatadd)
        Me.TabPage3.Controls.Add(Me.ferrerorem)
        Me.TabPage3.Controls.Add(Me.oreocount)
        Me.TabPage3.Controls.Add(Me.darkchocorem)
        Me.TabPage3.Controls.Add(Me.snickersadd)
        Me.TabPage3.Controls.Add(Me.kitkatrem)
        Me.TabPage3.Controls.Add(Me.r1lab)
        Me.TabPage3.Controls.Add(Me.snickersrem)
        Me.TabPage3.Controls.Add(Me.oreoadd)
        Me.TabPage3.Controls.Add(Me.oreorem)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Crushers"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ferrerocount
        '
        Me.ferrerocount.Cursor = System.Windows.Forms.Cursors.No
        Me.ferrerocount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "r5db", True))
        Me.ferrerocount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.ferrerocount.Location = New System.Drawing.Point(151, 665)
        Me.ferrerocount.Name = "ferrerocount"
        Me.ferrerocount.ReadOnly = True
        Me.ferrerocount.Size = New System.Drawing.Size(100, 64)
        Me.ferrerocount.TabIndex = 11
        Me.ferrerocount.Text = "0"
        Me.ferrerocount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'r5lab
        '
        Me.r5lab.AutoSize = True
        Me.r5lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r5lab.Location = New System.Drawing.Point(12, 609)
        Me.r5lab.Name = "r5lab"
        Me.r5lab.Size = New System.Drawing.Size(380, 52)
        Me.r5lab.TabIndex = 9
        Me.r5lab.Text = "Ferrero Rocher Crusher"
        '
        'darkchococount
        '
        Me.darkchococount.Cursor = System.Windows.Forms.Cursors.No
        Me.darkchococount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "r4db", True))
        Me.darkchococount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.darkchococount.Location = New System.Drawing.Point(151, 509)
        Me.darkchococount.Name = "darkchococount"
        Me.darkchococount.ReadOnly = True
        Me.darkchococount.Size = New System.Drawing.Size(100, 64)
        Me.darkchococount.TabIndex = 11
        Me.darkchococount.Text = "0"
        Me.darkchococount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'r4lab
        '
        Me.r4lab.AutoSize = True
        Me.r4lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r4lab.Location = New System.Drawing.Point(12, 453)
        Me.r4lab.Name = "r4lab"
        Me.r4lab.Size = New System.Drawing.Size(371, 52)
        Me.r4lab.TabIndex = 9
        Me.r4lab.Text = "Dark Chocolate Crusher"
        '
        'kitkatcount
        '
        Me.kitkatcount.Cursor = System.Windows.Forms.Cursors.No
        Me.kitkatcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "r3db", True))
        Me.kitkatcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.kitkatcount.Location = New System.Drawing.Point(151, 369)
        Me.kitkatcount.Name = "kitkatcount"
        Me.kitkatcount.ReadOnly = True
        Me.kitkatcount.Size = New System.Drawing.Size(100, 64)
        Me.kitkatcount.TabIndex = 11
        Me.kitkatcount.Text = "0"
        Me.kitkatcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'r3lab
        '
        Me.r3lab.AutoSize = True
        Me.r3lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r3lab.Location = New System.Drawing.Point(76, 313)
        Me.r3lab.Name = "r3lab"
        Me.r3lab.Size = New System.Drawing.Size(235, 52)
        Me.r3lab.TabIndex = 9
        Me.r3lab.Text = "Kitkat Crusher"
        '
        'ferreroadd
        '
        Me.ferreroadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ferreroadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ferreroadd.Location = New System.Drawing.Point(256, 665)
        Me.ferreroadd.Name = "ferreroadd"
        Me.ferreroadd.Size = New System.Drawing.Size(111, 64)
        Me.ferreroadd.TabIndex = 7
        Me.ferreroadd.Text = "+"
        Me.ferreroadd.UseVisualStyleBackColor = True
        '
        'snickerscount
        '
        Me.snickerscount.Cursor = System.Windows.Forms.Cursors.No
        Me.snickerscount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "r2db", True))
        Me.snickerscount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.snickerscount.Location = New System.Drawing.Point(151, 225)
        Me.snickerscount.Name = "snickerscount"
        Me.snickerscount.ReadOnly = True
        Me.snickerscount.Size = New System.Drawing.Size(100, 64)
        Me.snickerscount.TabIndex = 11
        Me.snickerscount.Text = "0"
        Me.snickerscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'darkchocoadd
        '
        Me.darkchocoadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.darkchocoadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.darkchocoadd.Location = New System.Drawing.Point(256, 509)
        Me.darkchocoadd.Name = "darkchocoadd"
        Me.darkchocoadd.Size = New System.Drawing.Size(111, 64)
        Me.darkchocoadd.TabIndex = 7
        Me.darkchocoadd.Text = "+"
        Me.darkchocoadd.UseVisualStyleBackColor = True
        '
        'r2lab
        '
        Me.r2lab.AutoSize = True
        Me.r2lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2lab.Location = New System.Drawing.Point(67, 169)
        Me.r2lab.Name = "r2lab"
        Me.r2lab.Size = New System.Drawing.Size(279, 52)
        Me.r2lab.TabIndex = 9
        Me.r2lab.Text = "Snickers Crusher"
        '
        'kitkatadd
        '
        Me.kitkatadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kitkatadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kitkatadd.Location = New System.Drawing.Point(256, 369)
        Me.kitkatadd.Name = "kitkatadd"
        Me.kitkatadd.Size = New System.Drawing.Size(111, 64)
        Me.kitkatadd.TabIndex = 7
        Me.kitkatadd.Text = "+"
        Me.kitkatadd.UseVisualStyleBackColor = True
        '
        'ferrerorem
        '
        Me.ferrerorem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ferrerorem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ferrerorem.Location = New System.Drawing.Point(34, 665)
        Me.ferrerorem.Name = "ferrerorem"
        Me.ferrerorem.Size = New System.Drawing.Size(111, 64)
        Me.ferrerorem.TabIndex = 8
        Me.ferrerorem.Text = "-"
        Me.ferrerorem.UseVisualStyleBackColor = True
        '
        'oreocount
        '
        Me.oreocount.Cursor = System.Windows.Forms.Cursors.No
        Me.oreocount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "r1db", True))
        Me.oreocount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.oreocount.Location = New System.Drawing.Point(151, 94)
        Me.oreocount.Name = "oreocount"
        Me.oreocount.ReadOnly = True
        Me.oreocount.Size = New System.Drawing.Size(100, 64)
        Me.oreocount.TabIndex = 11
        Me.oreocount.Text = "0"
        Me.oreocount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'darkchocorem
        '
        Me.darkchocorem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.darkchocorem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.darkchocorem.Location = New System.Drawing.Point(34, 509)
        Me.darkchocorem.Name = "darkchocorem"
        Me.darkchocorem.Size = New System.Drawing.Size(111, 64)
        Me.darkchocorem.TabIndex = 8
        Me.darkchocorem.Text = "-"
        Me.darkchocorem.UseVisualStyleBackColor = True
        '
        'snickersadd
        '
        Me.snickersadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.snickersadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.snickersadd.Location = New System.Drawing.Point(256, 225)
        Me.snickersadd.Name = "snickersadd"
        Me.snickersadd.Size = New System.Drawing.Size(111, 64)
        Me.snickersadd.TabIndex = 7
        Me.snickersadd.Text = "+"
        Me.snickersadd.UseVisualStyleBackColor = True
        '
        'kitkatrem
        '
        Me.kitkatrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kitkatrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kitkatrem.Location = New System.Drawing.Point(34, 369)
        Me.kitkatrem.Name = "kitkatrem"
        Me.kitkatrem.Size = New System.Drawing.Size(111, 64)
        Me.kitkatrem.TabIndex = 8
        Me.kitkatrem.Text = "-"
        Me.kitkatrem.UseVisualStyleBackColor = True
        '
        'r1lab
        '
        Me.r1lab.AutoSize = True
        Me.r1lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1lab.Location = New System.Drawing.Point(93, 38)
        Me.r1lab.Name = "r1lab"
        Me.r1lab.Size = New System.Drawing.Size(222, 52)
        Me.r1lab.TabIndex = 9
        Me.r1lab.Text = "Oreo Crusher"
        '
        'snickersrem
        '
        Me.snickersrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.snickersrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.snickersrem.Location = New System.Drawing.Point(34, 225)
        Me.snickersrem.Name = "snickersrem"
        Me.snickersrem.Size = New System.Drawing.Size(111, 64)
        Me.snickersrem.TabIndex = 8
        Me.snickersrem.Text = "-"
        Me.snickersrem.UseVisualStyleBackColor = True
        '
        'oreoadd
        '
        Me.oreoadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oreoadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oreoadd.Location = New System.Drawing.Point(256, 94)
        Me.oreoadd.Name = "oreoadd"
        Me.oreoadd.Size = New System.Drawing.Size(111, 64)
        Me.oreoadd.TabIndex = 7
        Me.oreoadd.Text = "+"
        Me.oreoadd.UseVisualStyleBackColor = True
        '
        'oreorem
        '
        Me.oreorem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oreorem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oreorem.Location = New System.Drawing.Point(34, 94)
        Me.oreorem.Name = "oreorem"
        Me.oreorem.Size = New System.Drawing.Size(111, 64)
        Me.oreorem.TabIndex = 8
        Me.oreorem.Text = "-"
        Me.oreorem.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.peanutbuttermilkcount)
        Me.TabPage4.Controls.Add(Me.bananamilkcount)
        Me.TabPage4.Controls.Add(Me.strawberrymilkcount)
        Me.TabPage4.Controls.Add(Me.mangomilkcount)
        Me.TabPage4.Controls.Add(Me.chocomilkcount)
        Me.TabPage4.Controls.Add(Me.vanillamilkcount)
        Me.TabPage4.Controls.Add(Me.m6lab)
        Me.TabPage4.Controls.Add(Me.peanutbuttermilkadd)
        Me.TabPage4.Controls.Add(Me.m5lab)
        Me.TabPage4.Controls.Add(Me.bananamilkadd)
        Me.TabPage4.Controls.Add(Me.m4lab)
        Me.TabPage4.Controls.Add(Me.strawberrymilkadd)
        Me.TabPage4.Controls.Add(Me.m3lab)
        Me.TabPage4.Controls.Add(Me.peanutbuttermilkrem)
        Me.TabPage4.Controls.Add(Me.mangomilkadd)
        Me.TabPage4.Controls.Add(Me.bananamilkrem)
        Me.TabPage4.Controls.Add(Me.m2lab)
        Me.TabPage4.Controls.Add(Me.strawberrymilkrem)
        Me.TabPage4.Controls.Add(Me.chocomilkadd)
        Me.TabPage4.Controls.Add(Me.mangomilkrem)
        Me.TabPage4.Controls.Add(Me.m1lab)
        Me.TabPage4.Controls.Add(Me.chocomilkrem)
        Me.TabPage4.Controls.Add(Me.vanillamilkadd)
        Me.TabPage4.Controls.Add(Me.vanillamilkrem)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Milkshake"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'peanutbuttermilkcount
        '
        Me.peanutbuttermilkcount.Cursor = System.Windows.Forms.Cursors.No
        Me.peanutbuttermilkcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "m6db", True))
        Me.peanutbuttermilkcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.peanutbuttermilkcount.Location = New System.Drawing.Point(156, 762)
        Me.peanutbuttermilkcount.Name = "peanutbuttermilkcount"
        Me.peanutbuttermilkcount.ReadOnly = True
        Me.peanutbuttermilkcount.Size = New System.Drawing.Size(100, 64)
        Me.peanutbuttermilkcount.TabIndex = 15
        Me.peanutbuttermilkcount.Text = "0"
        Me.peanutbuttermilkcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bananamilkcount
        '
        Me.bananamilkcount.Cursor = System.Windows.Forms.Cursors.No
        Me.bananamilkcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "m5db", True))
        Me.bananamilkcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.bananamilkcount.Location = New System.Drawing.Point(156, 625)
        Me.bananamilkcount.Name = "bananamilkcount"
        Me.bananamilkcount.ReadOnly = True
        Me.bananamilkcount.Size = New System.Drawing.Size(100, 64)
        Me.bananamilkcount.TabIndex = 15
        Me.bananamilkcount.Text = "0"
        Me.bananamilkcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'strawberrymilkcount
        '
        Me.strawberrymilkcount.Cursor = System.Windows.Forms.Cursors.No
        Me.strawberrymilkcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "m4db", True))
        Me.strawberrymilkcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.strawberrymilkcount.Location = New System.Drawing.Point(156, 493)
        Me.strawberrymilkcount.Name = "strawberrymilkcount"
        Me.strawberrymilkcount.ReadOnly = True
        Me.strawberrymilkcount.Size = New System.Drawing.Size(100, 64)
        Me.strawberrymilkcount.TabIndex = 15
        Me.strawberrymilkcount.Text = "0"
        Me.strawberrymilkcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mangomilkcount
        '
        Me.mangomilkcount.Cursor = System.Windows.Forms.Cursors.No
        Me.mangomilkcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "m3db", True))
        Me.mangomilkcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.mangomilkcount.Location = New System.Drawing.Point(156, 356)
        Me.mangomilkcount.Name = "mangomilkcount"
        Me.mangomilkcount.ReadOnly = True
        Me.mangomilkcount.Size = New System.Drawing.Size(100, 64)
        Me.mangomilkcount.TabIndex = 15
        Me.mangomilkcount.Text = "0"
        Me.mangomilkcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chocomilkcount
        '
        Me.chocomilkcount.Cursor = System.Windows.Forms.Cursors.No
        Me.chocomilkcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "m2db", True))
        Me.chocomilkcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.chocomilkcount.Location = New System.Drawing.Point(156, 224)
        Me.chocomilkcount.Name = "chocomilkcount"
        Me.chocomilkcount.ReadOnly = True
        Me.chocomilkcount.Size = New System.Drawing.Size(100, 64)
        Me.chocomilkcount.TabIndex = 15
        Me.chocomilkcount.Text = "0"
        Me.chocomilkcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'vanillamilkcount
        '
        Me.vanillamilkcount.Cursor = System.Windows.Forms.Cursors.No
        Me.vanillamilkcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "m1db", True))
        Me.vanillamilkcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.vanillamilkcount.Location = New System.Drawing.Point(156, 88)
        Me.vanillamilkcount.Name = "vanillamilkcount"
        Me.vanillamilkcount.ReadOnly = True
        Me.vanillamilkcount.Size = New System.Drawing.Size(100, 64)
        Me.vanillamilkcount.TabIndex = 15
        Me.vanillamilkcount.Text = "0"
        Me.vanillamilkcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'm6lab
        '
        Me.m6lab.AutoSize = True
        Me.m6lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m6lab.Location = New System.Drawing.Point(9, 706)
        Me.m6lab.Name = "m6lab"
        Me.m6lab.Size = New System.Drawing.Size(385, 52)
        Me.m6lab.TabIndex = 14
        Me.m6lab.Text = "Peanut Butter Milk Shake"
        '
        'peanutbuttermilkadd
        '
        Me.peanutbuttermilkadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.peanutbuttermilkadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peanutbuttermilkadd.Location = New System.Drawing.Point(261, 762)
        Me.peanutbuttermilkadd.Name = "peanutbuttermilkadd"
        Me.peanutbuttermilkadd.Size = New System.Drawing.Size(111, 64)
        Me.peanutbuttermilkadd.TabIndex = 12
        Me.peanutbuttermilkadd.Text = "+"
        Me.peanutbuttermilkadd.UseVisualStyleBackColor = True
        '
        'm5lab
        '
        Me.m5lab.AutoSize = True
        Me.m5lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m5lab.Location = New System.Drawing.Point(61, 569)
        Me.m5lab.Name = "m5lab"
        Me.m5lab.Size = New System.Drawing.Size(287, 52)
        Me.m5lab.TabIndex = 14
        Me.m5lab.Text = "Banana Milk Shake"
        '
        'bananamilkadd
        '
        Me.bananamilkadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bananamilkadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bananamilkadd.Location = New System.Drawing.Point(261, 625)
        Me.bananamilkadd.Name = "bananamilkadd"
        Me.bananamilkadd.Size = New System.Drawing.Size(111, 64)
        Me.bananamilkadd.TabIndex = 12
        Me.bananamilkadd.Text = "+"
        Me.bananamilkadd.UseVisualStyleBackColor = True
        '
        'm4lab
        '
        Me.m4lab.AutoSize = True
        Me.m4lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m4lab.Location = New System.Drawing.Point(29, 437)
        Me.m4lab.Name = "m4lab"
        Me.m4lab.Size = New System.Drawing.Size(353, 52)
        Me.m4lab.TabIndex = 14
        Me.m4lab.Text = "Strawberry Milk Shake"
        '
        'strawberrymilkadd
        '
        Me.strawberrymilkadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.strawberrymilkadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strawberrymilkadd.Location = New System.Drawing.Point(261, 493)
        Me.strawberrymilkadd.Name = "strawberrymilkadd"
        Me.strawberrymilkadd.Size = New System.Drawing.Size(111, 64)
        Me.strawberrymilkadd.TabIndex = 12
        Me.strawberrymilkadd.Text = "+"
        Me.strawberrymilkadd.UseVisualStyleBackColor = True
        '
        'm3lab
        '
        Me.m3lab.AutoSize = True
        Me.m3lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m3lab.Location = New System.Drawing.Point(68, 300)
        Me.m3lab.Name = "m3lab"
        Me.m3lab.Size = New System.Drawing.Size(274, 52)
        Me.m3lab.TabIndex = 14
        Me.m3lab.Text = "Mango Milk Shake"
        '
        'peanutbuttermilkrem
        '
        Me.peanutbuttermilkrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.peanutbuttermilkrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peanutbuttermilkrem.Location = New System.Drawing.Point(39, 762)
        Me.peanutbuttermilkrem.Name = "peanutbuttermilkrem"
        Me.peanutbuttermilkrem.Size = New System.Drawing.Size(111, 64)
        Me.peanutbuttermilkrem.TabIndex = 13
        Me.peanutbuttermilkrem.Text = "-"
        Me.peanutbuttermilkrem.UseVisualStyleBackColor = True
        '
        'mangomilkadd
        '
        Me.mangomilkadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mangomilkadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mangomilkadd.Location = New System.Drawing.Point(261, 356)
        Me.mangomilkadd.Name = "mangomilkadd"
        Me.mangomilkadd.Size = New System.Drawing.Size(111, 64)
        Me.mangomilkadd.TabIndex = 12
        Me.mangomilkadd.Text = "+"
        Me.mangomilkadd.UseVisualStyleBackColor = True
        '
        'bananamilkrem
        '
        Me.bananamilkrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bananamilkrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bananamilkrem.Location = New System.Drawing.Point(39, 625)
        Me.bananamilkrem.Name = "bananamilkrem"
        Me.bananamilkrem.Size = New System.Drawing.Size(111, 64)
        Me.bananamilkrem.TabIndex = 13
        Me.bananamilkrem.Text = "-"
        Me.bananamilkrem.UseVisualStyleBackColor = True
        '
        'm2lab
        '
        Me.m2lab.AutoSize = True
        Me.m2lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m2lab.Location = New System.Drawing.Point(41, 168)
        Me.m2lab.Name = "m2lab"
        Me.m2lab.Size = New System.Drawing.Size(324, 52)
        Me.m2lab.TabIndex = 14
        Me.m2lab.Text = "Chocolate Milk Shake"
        '
        'strawberrymilkrem
        '
        Me.strawberrymilkrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.strawberrymilkrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strawberrymilkrem.Location = New System.Drawing.Point(39, 493)
        Me.strawberrymilkrem.Name = "strawberrymilkrem"
        Me.strawberrymilkrem.Size = New System.Drawing.Size(111, 64)
        Me.strawberrymilkrem.TabIndex = 13
        Me.strawberrymilkrem.Text = "-"
        Me.strawberrymilkrem.UseVisualStyleBackColor = True
        '
        'chocomilkadd
        '
        Me.chocomilkadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chocomilkadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chocomilkadd.Location = New System.Drawing.Point(261, 224)
        Me.chocomilkadd.Name = "chocomilkadd"
        Me.chocomilkadd.Size = New System.Drawing.Size(111, 64)
        Me.chocomilkadd.TabIndex = 12
        Me.chocomilkadd.Text = "+"
        Me.chocomilkadd.UseVisualStyleBackColor = True
        '
        'mangomilkrem
        '
        Me.mangomilkrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mangomilkrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mangomilkrem.Location = New System.Drawing.Point(39, 356)
        Me.mangomilkrem.Name = "mangomilkrem"
        Me.mangomilkrem.Size = New System.Drawing.Size(111, 64)
        Me.mangomilkrem.TabIndex = 13
        Me.mangomilkrem.Text = "-"
        Me.mangomilkrem.UseVisualStyleBackColor = True
        '
        'm1lab
        '
        Me.m1lab.AutoSize = True
        Me.m1lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m1lab.Location = New System.Drawing.Point(73, 32)
        Me.m1lab.Name = "m1lab"
        Me.m1lab.Size = New System.Drawing.Size(274, 52)
        Me.m1lab.TabIndex = 14
        Me.m1lab.Text = "Vanilla Milk Shake"
        '
        'chocomilkrem
        '
        Me.chocomilkrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chocomilkrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chocomilkrem.Location = New System.Drawing.Point(39, 224)
        Me.chocomilkrem.Name = "chocomilkrem"
        Me.chocomilkrem.Size = New System.Drawing.Size(111, 64)
        Me.chocomilkrem.TabIndex = 13
        Me.chocomilkrem.Text = "-"
        Me.chocomilkrem.UseVisualStyleBackColor = True
        '
        'vanillamilkadd
        '
        Me.vanillamilkadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vanillamilkadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vanillamilkadd.Location = New System.Drawing.Point(261, 88)
        Me.vanillamilkadd.Name = "vanillamilkadd"
        Me.vanillamilkadd.Size = New System.Drawing.Size(111, 64)
        Me.vanillamilkadd.TabIndex = 12
        Me.vanillamilkadd.Text = "+"
        Me.vanillamilkadd.UseVisualStyleBackColor = True
        '
        'vanillamilkrem
        '
        Me.vanillamilkrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vanillamilkrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vanillamilkrem.Location = New System.Drawing.Point(39, 88)
        Me.vanillamilkrem.Name = "vanillamilkrem"
        Me.vanillamilkrem.Size = New System.Drawing.Size(111, 64)
        Me.vanillamilkrem.TabIndex = 13
        Me.vanillamilkrem.Text = "-"
        Me.vanillamilkrem.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.orangelemoncount)
        Me.TabPage5.Controls.Add(Me.lemonmojitocount)
        Me.TabPage5.Controls.Add(Me.n2lab)
        Me.TabPage5.Controls.Add(Me.orangelemonadd)
        Me.TabPage5.Controls.Add(Me.n1lab)
        Me.TabPage5.Controls.Add(Me.orangelemonrem)
        Me.TabPage5.Controls.Add(Me.lemonmojitoadd)
        Me.TabPage5.Controls.Add(Me.lemonmojitorem)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Lemonade"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'orangelemoncount
        '
        Me.orangelemoncount.Cursor = System.Windows.Forms.Cursors.No
        Me.orangelemoncount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "n2db", True))
        Me.orangelemoncount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.orangelemoncount.Location = New System.Drawing.Point(154, 389)
        Me.orangelemoncount.Name = "orangelemoncount"
        Me.orangelemoncount.ReadOnly = True
        Me.orangelemoncount.Size = New System.Drawing.Size(100, 64)
        Me.orangelemoncount.TabIndex = 19
        Me.orangelemoncount.Text = "0"
        Me.orangelemoncount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lemonmojitocount
        '
        Me.lemonmojitocount.Cursor = System.Windows.Forms.Cursors.No
        Me.lemonmojitocount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "n1db", True))
        Me.lemonmojitocount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.lemonmojitocount.Location = New System.Drawing.Point(154, 185)
        Me.lemonmojitocount.Name = "lemonmojitocount"
        Me.lemonmojitocount.ReadOnly = True
        Me.lemonmojitocount.Size = New System.Drawing.Size(100, 64)
        Me.lemonmojitocount.TabIndex = 19
        Me.lemonmojitocount.Text = "0"
        Me.lemonmojitocount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'n2lab
        '
        Me.n2lab.AutoSize = True
        Me.n2lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n2lab.Location = New System.Drawing.Point(69, 334)
        Me.n2lab.Name = "n2lab"
        Me.n2lab.Size = New System.Drawing.Size(278, 52)
        Me.n2lab.TabIndex = 18
        Me.n2lab.Text = "Orange Lemonade"
        '
        'orangelemonadd
        '
        Me.orangelemonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orangelemonadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orangelemonadd.Location = New System.Drawing.Point(259, 389)
        Me.orangelemonadd.Name = "orangelemonadd"
        Me.orangelemonadd.Size = New System.Drawing.Size(111, 64)
        Me.orangelemonadd.TabIndex = 16
        Me.orangelemonadd.Text = "+"
        Me.orangelemonadd.UseVisualStyleBackColor = True
        '
        'n1lab
        '
        Me.n1lab.AutoSize = True
        Me.n1lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n1lab.Location = New System.Drawing.Point(102, 130)
        Me.n1lab.Name = "n1lab"
        Me.n1lab.Size = New System.Drawing.Size(209, 52)
        Me.n1lab.TabIndex = 18
        Me.n1lab.Text = "Lemon Mojito"
        '
        'orangelemonrem
        '
        Me.orangelemonrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orangelemonrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orangelemonrem.Location = New System.Drawing.Point(37, 389)
        Me.orangelemonrem.Name = "orangelemonrem"
        Me.orangelemonrem.Size = New System.Drawing.Size(111, 64)
        Me.orangelemonrem.TabIndex = 17
        Me.orangelemonrem.Text = "-"
        Me.orangelemonrem.UseVisualStyleBackColor = True
        '
        'lemonmojitoadd
        '
        Me.lemonmojitoadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lemonmojitoadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lemonmojitoadd.Location = New System.Drawing.Point(259, 185)
        Me.lemonmojitoadd.Name = "lemonmojitoadd"
        Me.lemonmojitoadd.Size = New System.Drawing.Size(111, 64)
        Me.lemonmojitoadd.TabIndex = 16
        Me.lemonmojitoadd.Text = "+"
        Me.lemonmojitoadd.UseVisualStyleBackColor = True
        '
        'lemonmojitorem
        '
        Me.lemonmojitorem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lemonmojitorem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lemonmojitorem.Location = New System.Drawing.Point(37, 185)
        Me.lemonmojitorem.Name = "lemonmojitorem"
        Me.lemonmojitorem.Size = New System.Drawing.Size(111, 64)
        Me.lemonmojitorem.TabIndex = 17
        Me.lemonmojitorem.Text = "-"
        Me.lemonmojitorem.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.mangolassicount)
        Me.TabPage6.Controls.Add(Me.espressolassicount)
        Me.TabPage6.Controls.Add(Me.lassicount)
        Me.TabPage6.Controls.Add(Me.l3lab)
        Me.TabPage6.Controls.Add(Me.mangolassiadd)
        Me.TabPage6.Controls.Add(Me.l2lab)
        Me.TabPage6.Controls.Add(Me.espressolassiadd)
        Me.TabPage6.Controls.Add(Me.mangolassirem)
        Me.TabPage6.Controls.Add(Me.l1lab)
        Me.TabPage6.Controls.Add(Me.espressolassirem)
        Me.TabPage6.Controls.Add(Me.lassiadd)
        Me.TabPage6.Controls.Add(Me.lassirem)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Lassi"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'mangolassicount
        '
        Me.mangolassicount.Cursor = System.Windows.Forms.Cursors.No
        Me.mangolassicount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "l3db", True))
        Me.mangolassicount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.mangolassicount.Location = New System.Drawing.Point(154, 437)
        Me.mangolassicount.Name = "mangolassicount"
        Me.mangolassicount.ReadOnly = True
        Me.mangolassicount.Size = New System.Drawing.Size(100, 64)
        Me.mangolassicount.TabIndex = 23
        Me.mangolassicount.Text = "0"
        Me.mangolassicount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'espressolassicount
        '
        Me.espressolassicount.Cursor = System.Windows.Forms.Cursors.No
        Me.espressolassicount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "l2db", True))
        Me.espressolassicount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.espressolassicount.Location = New System.Drawing.Point(154, 284)
        Me.espressolassicount.Name = "espressolassicount"
        Me.espressolassicount.ReadOnly = True
        Me.espressolassicount.Size = New System.Drawing.Size(100, 64)
        Me.espressolassicount.TabIndex = 23
        Me.espressolassicount.Text = "0"
        Me.espressolassicount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lassicount
        '
        Me.lassicount.Cursor = System.Windows.Forms.Cursors.No
        Me.lassicount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "l1db", True))
        Me.lassicount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.lassicount.Location = New System.Drawing.Point(154, 141)
        Me.lassicount.Name = "lassicount"
        Me.lassicount.ReadOnly = True
        Me.lassicount.Size = New System.Drawing.Size(100, 64)
        Me.lassicount.TabIndex = 23
        Me.lassicount.Text = "0"
        Me.lassicount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'l3lab
        '
        Me.l3lab.AutoSize = True
        Me.l3lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3lab.Location = New System.Drawing.Point(110, 382)
        Me.l3lab.Name = "l3lab"
        Me.l3lab.Size = New System.Drawing.Size(197, 52)
        Me.l3lab.TabIndex = 22
        Me.l3lab.Text = "Mango Lassi"
        '
        'mangolassiadd
        '
        Me.mangolassiadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mangolassiadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mangolassiadd.Location = New System.Drawing.Point(259, 437)
        Me.mangolassiadd.Name = "mangolassiadd"
        Me.mangolassiadd.Size = New System.Drawing.Size(111, 64)
        Me.mangolassiadd.TabIndex = 20
        Me.mangolassiadd.Text = "+"
        Me.mangolassiadd.UseVisualStyleBackColor = True
        '
        'l2lab
        '
        Me.l2lab.AutoSize = True
        Me.l2lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2lab.Location = New System.Drawing.Point(91, 229)
        Me.l2lab.Name = "l2lab"
        Me.l2lab.Size = New System.Drawing.Size(240, 52)
        Me.l2lab.TabIndex = 22
        Me.l2lab.Text = "Espresso Lassi"
        '
        'espressolassiadd
        '
        Me.espressolassiadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.espressolassiadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.espressolassiadd.Location = New System.Drawing.Point(259, 284)
        Me.espressolassiadd.Name = "espressolassiadd"
        Me.espressolassiadd.Size = New System.Drawing.Size(111, 64)
        Me.espressolassiadd.TabIndex = 20
        Me.espressolassiadd.Text = "+"
        Me.espressolassiadd.UseVisualStyleBackColor = True
        '
        'mangolassirem
        '
        Me.mangolassirem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mangolassirem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mangolassirem.Location = New System.Drawing.Point(37, 437)
        Me.mangolassirem.Name = "mangolassirem"
        Me.mangolassirem.Size = New System.Drawing.Size(111, 64)
        Me.mangolassirem.TabIndex = 21
        Me.mangolassirem.Text = "-"
        Me.mangolassirem.UseVisualStyleBackColor = True
        '
        'l1lab
        '
        Me.l1lab.AutoSize = True
        Me.l1lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1lab.Location = New System.Drawing.Point(102, 86)
        Me.l1lab.Name = "l1lab"
        Me.l1lab.Size = New System.Drawing.Size(217, 52)
        Me.l1lab.TabIndex = 22
        Me.l1lab.Text = "Lassi Regular"
        '
        'espressolassirem
        '
        Me.espressolassirem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.espressolassirem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.espressolassirem.Location = New System.Drawing.Point(37, 284)
        Me.espressolassirem.Name = "espressolassirem"
        Me.espressolassirem.Size = New System.Drawing.Size(111, 64)
        Me.espressolassirem.TabIndex = 21
        Me.espressolassirem.Text = "-"
        Me.espressolassirem.UseVisualStyleBackColor = True
        '
        'lassiadd
        '
        Me.lassiadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lassiadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lassiadd.Location = New System.Drawing.Point(259, 141)
        Me.lassiadd.Name = "lassiadd"
        Me.lassiadd.Size = New System.Drawing.Size(111, 64)
        Me.lassiadd.TabIndex = 20
        Me.lassiadd.Text = "+"
        Me.lassiadd.UseVisualStyleBackColor = True
        '
        'lassirem
        '
        Me.lassirem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lassirem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lassirem.Location = New System.Drawing.Point(37, 141)
        Me.lassirem.Name = "lassirem"
        Me.lassirem.Size = New System.Drawing.Size(111, 64)
        Me.lassirem.TabIndex = 21
        Me.lassirem.Text = "-"
        Me.lassirem.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.darkcurrantcount)
        Me.TabPage7.Controls.Add(Me.yellowpunchcount)
        Me.TabPage7.Controls.Add(Me.bluebersparkcount)
        Me.TabPage7.Controls.Add(Me.grapeinvadecount)
        Me.TabPage7.Controls.Add(Me.virapplecount)
        Me.TabPage7.Controls.Add(Me.virsangriacount)
        Me.TabPage7.Controls.Add(Me.virsanfrancount)
        Me.TabPage7.Controls.Add(Me.k7lab)
        Me.TabPage7.Controls.Add(Me.darkcurrantadd)
        Me.TabPage7.Controls.Add(Me.k6lab)
        Me.TabPage7.Controls.Add(Me.yellowpunchadd)
        Me.TabPage7.Controls.Add(Me.k5lab)
        Me.TabPage7.Controls.Add(Me.bluebersparkadd)
        Me.TabPage7.Controls.Add(Me.k4lab)
        Me.TabPage7.Controls.Add(Me.grapeinvadeadd)
        Me.TabPage7.Controls.Add(Me.darkcurrantrem)
        Me.TabPage7.Controls.Add(Me.k3lab)
        Me.TabPage7.Controls.Add(Me.yellowpunchrem)
        Me.TabPage7.Controls.Add(Me.virappleadd)
        Me.TabPage7.Controls.Add(Me.bluebersparkrem)
        Me.TabPage7.Controls.Add(Me.k2lab)
        Me.TabPage7.Controls.Add(Me.grapeinvaderem)
        Me.TabPage7.Controls.Add(Me.virsangriaadd)
        Me.TabPage7.Controls.Add(Me.virapplerem)
        Me.TabPage7.Controls.Add(Me.k1lab)
        Me.TabPage7.Controls.Add(Me.virsangriarem)
        Me.TabPage7.Controls.Add(Me.virsanfranadd)
        Me.TabPage7.Controls.Add(Me.virsanfranrem)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Mocktail"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'darkcurrantcount
        '
        Me.darkcurrantcount.Cursor = System.Windows.Forms.Cursors.No
        Me.darkcurrantcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "k7db", True))
        Me.darkcurrantcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.darkcurrantcount.Location = New System.Drawing.Point(153, 822)
        Me.darkcurrantcount.Name = "darkcurrantcount"
        Me.darkcurrantcount.ReadOnly = True
        Me.darkcurrantcount.Size = New System.Drawing.Size(100, 64)
        Me.darkcurrantcount.TabIndex = 27
        Me.darkcurrantcount.Text = "0"
        Me.darkcurrantcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yellowpunchcount
        '
        Me.yellowpunchcount.Cursor = System.Windows.Forms.Cursors.No
        Me.yellowpunchcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "k6db", True))
        Me.yellowpunchcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.yellowpunchcount.Location = New System.Drawing.Point(153, 700)
        Me.yellowpunchcount.Name = "yellowpunchcount"
        Me.yellowpunchcount.ReadOnly = True
        Me.yellowpunchcount.Size = New System.Drawing.Size(100, 64)
        Me.yellowpunchcount.TabIndex = 27
        Me.yellowpunchcount.Text = "0"
        Me.yellowpunchcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bluebersparkcount
        '
        Me.bluebersparkcount.Cursor = System.Windows.Forms.Cursors.No
        Me.bluebersparkcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "k5db", True))
        Me.bluebersparkcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.bluebersparkcount.Location = New System.Drawing.Point(153, 576)
        Me.bluebersparkcount.Name = "bluebersparkcount"
        Me.bluebersparkcount.ReadOnly = True
        Me.bluebersparkcount.Size = New System.Drawing.Size(100, 64)
        Me.bluebersparkcount.TabIndex = 27
        Me.bluebersparkcount.Text = "0"
        Me.bluebersparkcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grapeinvadecount
        '
        Me.grapeinvadecount.Cursor = System.Windows.Forms.Cursors.No
        Me.grapeinvadecount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "k4db", True))
        Me.grapeinvadecount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.grapeinvadecount.Location = New System.Drawing.Point(153, 454)
        Me.grapeinvadecount.Name = "grapeinvadecount"
        Me.grapeinvadecount.ReadOnly = True
        Me.grapeinvadecount.Size = New System.Drawing.Size(100, 64)
        Me.grapeinvadecount.TabIndex = 27
        Me.grapeinvadecount.Text = "0"
        Me.grapeinvadecount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'virapplecount
        '
        Me.virapplecount.Cursor = System.Windows.Forms.Cursors.No
        Me.virapplecount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "k3db", True))
        Me.virapplecount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.virapplecount.Location = New System.Drawing.Point(153, 332)
        Me.virapplecount.Name = "virapplecount"
        Me.virapplecount.ReadOnly = True
        Me.virapplecount.Size = New System.Drawing.Size(100, 64)
        Me.virapplecount.TabIndex = 27
        Me.virapplecount.Text = "0"
        Me.virapplecount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'virsangriacount
        '
        Me.virsangriacount.Cursor = System.Windows.Forms.Cursors.No
        Me.virsangriacount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "k2db", True))
        Me.virsangriacount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.virsangriacount.Location = New System.Drawing.Point(153, 209)
        Me.virsangriacount.Name = "virsangriacount"
        Me.virsangriacount.ReadOnly = True
        Me.virsangriacount.Size = New System.Drawing.Size(100, 64)
        Me.virsangriacount.TabIndex = 27
        Me.virsangriacount.Text = "0"
        Me.virsangriacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'virsanfrancount
        '
        Me.virsanfrancount.Cursor = System.Windows.Forms.Cursors.No
        Me.virsanfrancount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "k1db", True))
        Me.virsanfrancount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.virsanfrancount.Location = New System.Drawing.Point(153, 87)
        Me.virsanfrancount.Name = "virsanfrancount"
        Me.virsanfrancount.ReadOnly = True
        Me.virsanfrancount.Size = New System.Drawing.Size(100, 64)
        Me.virsanfrancount.TabIndex = 27
        Me.virsanfrancount.Text = "0"
        Me.virsanfrancount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'k7lab
        '
        Me.k7lab.AutoSize = True
        Me.k7lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.k7lab.Location = New System.Drawing.Point(94, 767)
        Me.k7lab.Name = "k7lab"
        Me.k7lab.Size = New System.Drawing.Size(215, 52)
        Me.k7lab.TabIndex = 26
        Me.k7lab.Text = "Dark Currant"
        '
        'darkcurrantadd
        '
        Me.darkcurrantadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.darkcurrantadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.darkcurrantadd.Location = New System.Drawing.Point(258, 822)
        Me.darkcurrantadd.Name = "darkcurrantadd"
        Me.darkcurrantadd.Size = New System.Drawing.Size(111, 64)
        Me.darkcurrantadd.TabIndex = 24
        Me.darkcurrantadd.Text = "+"
        Me.darkcurrantadd.UseVisualStyleBackColor = True
        '
        'k6lab
        '
        Me.k6lab.AutoSize = True
        Me.k6lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.k6lab.Location = New System.Drawing.Point(101, 645)
        Me.k6lab.Name = "k6lab"
        Me.k6lab.Size = New System.Drawing.Size(213, 52)
        Me.k6lab.TabIndex = 26
        Me.k6lab.Text = "Yellow Punch"
        '
        'yellowpunchadd
        '
        Me.yellowpunchadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yellowpunchadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yellowpunchadd.Location = New System.Drawing.Point(258, 700)
        Me.yellowpunchadd.Name = "yellowpunchadd"
        Me.yellowpunchadd.Size = New System.Drawing.Size(111, 64)
        Me.yellowpunchadd.TabIndex = 24
        Me.yellowpunchadd.Text = "+"
        Me.yellowpunchadd.UseVisualStyleBackColor = True
        '
        'k5lab
        '
        Me.k5lab.AutoSize = True
        Me.k5lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.k5lab.Location = New System.Drawing.Point(49, 521)
        Me.k5lab.Name = "k5lab"
        Me.k5lab.Size = New System.Drawing.Size(301, 52)
        Me.k5lab.TabIndex = 26
        Me.k5lab.Text = "Blueberry Sparkler"
        '
        'bluebersparkadd
        '
        Me.bluebersparkadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bluebersparkadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bluebersparkadd.Location = New System.Drawing.Point(258, 576)
        Me.bluebersparkadd.Name = "bluebersparkadd"
        Me.bluebersparkadd.Size = New System.Drawing.Size(111, 64)
        Me.bluebersparkadd.TabIndex = 24
        Me.bluebersparkadd.Text = "+"
        Me.bluebersparkadd.UseVisualStyleBackColor = True
        '
        'k4lab
        '
        Me.k4lab.AutoSize = True
        Me.k4lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.k4lab.Location = New System.Drawing.Point(92, 399)
        Me.k4lab.Name = "k4lab"
        Me.k4lab.Size = New System.Drawing.Size(226, 52)
        Me.k4lab.TabIndex = 26
        Me.k4lab.Text = "Grape Invader"
        '
        'grapeinvadeadd
        '
        Me.grapeinvadeadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grapeinvadeadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grapeinvadeadd.Location = New System.Drawing.Point(258, 454)
        Me.grapeinvadeadd.Name = "grapeinvadeadd"
        Me.grapeinvadeadd.Size = New System.Drawing.Size(111, 64)
        Me.grapeinvadeadd.TabIndex = 24
        Me.grapeinvadeadd.Text = "+"
        Me.grapeinvadeadd.UseVisualStyleBackColor = True
        '
        'darkcurrantrem
        '
        Me.darkcurrantrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.darkcurrantrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.darkcurrantrem.Location = New System.Drawing.Point(36, 822)
        Me.darkcurrantrem.Name = "darkcurrantrem"
        Me.darkcurrantrem.Size = New System.Drawing.Size(111, 64)
        Me.darkcurrantrem.TabIndex = 25
        Me.darkcurrantrem.Text = "-"
        Me.darkcurrantrem.UseVisualStyleBackColor = True
        '
        'k3lab
        '
        Me.k3lab.AutoSize = True
        Me.k3lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.k3lab.Location = New System.Drawing.Point(85, 277)
        Me.k3lab.Name = "k3lab"
        Me.k3lab.Size = New System.Drawing.Size(236, 52)
        Me.k3lab.TabIndex = 26
        Me.k3lab.Text = "Virgin Appletini"
        '
        'yellowpunchrem
        '
        Me.yellowpunchrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yellowpunchrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yellowpunchrem.Location = New System.Drawing.Point(36, 700)
        Me.yellowpunchrem.Name = "yellowpunchrem"
        Me.yellowpunchrem.Size = New System.Drawing.Size(111, 64)
        Me.yellowpunchrem.TabIndex = 25
        Me.yellowpunchrem.Text = "-"
        Me.yellowpunchrem.UseVisualStyleBackColor = True
        '
        'virappleadd
        '
        Me.virappleadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.virappleadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virappleadd.Location = New System.Drawing.Point(258, 332)
        Me.virappleadd.Name = "virappleadd"
        Me.virappleadd.Size = New System.Drawing.Size(111, 64)
        Me.virappleadd.TabIndex = 24
        Me.virappleadd.Text = "+"
        Me.virappleadd.UseVisualStyleBackColor = True
        '
        'bluebersparkrem
        '
        Me.bluebersparkrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bluebersparkrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bluebersparkrem.Location = New System.Drawing.Point(36, 576)
        Me.bluebersparkrem.Name = "bluebersparkrem"
        Me.bluebersparkrem.Size = New System.Drawing.Size(111, 64)
        Me.bluebersparkrem.TabIndex = 25
        Me.bluebersparkrem.Text = "-"
        Me.bluebersparkrem.UseVisualStyleBackColor = True
        '
        'k2lab
        '
        Me.k2lab.AutoSize = True
        Me.k2lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.k2lab.Location = New System.Drawing.Point(89, 154)
        Me.k2lab.Name = "k2lab"
        Me.k2lab.Size = New System.Drawing.Size(227, 52)
        Me.k2lab.TabIndex = 26
        Me.k2lab.Text = "Virgin Sangria"
        '
        'grapeinvaderem
        '
        Me.grapeinvaderem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grapeinvaderem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grapeinvaderem.Location = New System.Drawing.Point(36, 454)
        Me.grapeinvaderem.Name = "grapeinvaderem"
        Me.grapeinvaderem.Size = New System.Drawing.Size(111, 64)
        Me.grapeinvaderem.TabIndex = 25
        Me.grapeinvaderem.Text = "-"
        Me.grapeinvaderem.UseVisualStyleBackColor = True
        '
        'virsangriaadd
        '
        Me.virsangriaadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.virsangriaadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virsangriaadd.Location = New System.Drawing.Point(258, 209)
        Me.virsangriaadd.Name = "virsangriaadd"
        Me.virsangriaadd.Size = New System.Drawing.Size(111, 64)
        Me.virsangriaadd.TabIndex = 24
        Me.virsangriaadd.Text = "+"
        Me.virsangriaadd.UseVisualStyleBackColor = True
        '
        'virapplerem
        '
        Me.virapplerem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.virapplerem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virapplerem.Location = New System.Drawing.Point(36, 332)
        Me.virapplerem.Name = "virapplerem"
        Me.virapplerem.Size = New System.Drawing.Size(111, 64)
        Me.virapplerem.TabIndex = 25
        Me.virapplerem.Text = "-"
        Me.virapplerem.UseVisualStyleBackColor = True
        '
        'k1lab
        '
        Me.k1lab.AutoSize = True
        Me.k1lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.k1lab.Location = New System.Drawing.Point(49, 32)
        Me.k1lab.Name = "k1lab"
        Me.k1lab.Size = New System.Drawing.Size(307, 52)
        Me.k1lab.TabIndex = 26
        Me.k1lab.Text = "Virgin Sanfrancisco"
        '
        'virsangriarem
        '
        Me.virsangriarem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.virsangriarem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virsangriarem.Location = New System.Drawing.Point(36, 209)
        Me.virsangriarem.Name = "virsangriarem"
        Me.virsangriarem.Size = New System.Drawing.Size(111, 64)
        Me.virsangriarem.TabIndex = 25
        Me.virsangriarem.Text = "-"
        Me.virsangriarem.UseVisualStyleBackColor = True
        '
        'virsanfranadd
        '
        Me.virsanfranadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.virsanfranadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virsanfranadd.Location = New System.Drawing.Point(258, 87)
        Me.virsanfranadd.Name = "virsanfranadd"
        Me.virsanfranadd.Size = New System.Drawing.Size(111, 64)
        Me.virsanfranadd.TabIndex = 24
        Me.virsanfranadd.Text = "+"
        Me.virsanfranadd.UseVisualStyleBackColor = True
        '
        'virsanfranrem
        '
        Me.virsanfranrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.virsanfranrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virsanfranrem.Location = New System.Drawing.Point(36, 87)
        Me.virsanfranrem.Name = "virsanfranrem"
        Me.virsanfranrem.Size = New System.Drawing.Size(111, 64)
        Me.virsanfranrem.TabIndex = 25
        Me.virsanfranrem.Text = "-"
        Me.virsanfranrem.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.peanutchilcount)
        Me.TabPage8.Controls.Add(Me.hazelchilcofcount)
        Me.TabPage8.Controls.Add(Me.caramelchilcofcount)
        Me.TabPage8.Controls.Add(Me.chocochilcofcount)
        Me.TabPage8.Controls.Add(Me.p4lab)
        Me.TabPage8.Controls.Add(Me.peanutchilcofadd)
        Me.TabPage8.Controls.Add(Me.p3lab)
        Me.TabPage8.Controls.Add(Me.hazelchilcofadd)
        Me.TabPage8.Controls.Add(Me.p2lab)
        Me.TabPage8.Controls.Add(Me.peanutchilrem)
        Me.TabPage8.Controls.Add(Me.caramelchilcofadd)
        Me.TabPage8.Controls.Add(Me.hazelchilcofrem)
        Me.TabPage8.Controls.Add(Me.p1lab)
        Me.TabPage8.Controls.Add(Me.caramelchilcofrem)
        Me.TabPage8.Controls.Add(Me.chocochilcofadd)
        Me.TabPage8.Controls.Add(Me.chocochilcofrem)
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Premium Chilled Coffee"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'peanutchilcount
        '
        Me.peanutchilcount.Cursor = System.Windows.Forms.Cursors.No
        Me.peanutchilcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "p4db", True))
        Me.peanutchilcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.peanutchilcount.Location = New System.Drawing.Point(154, 588)
        Me.peanutchilcount.Name = "peanutchilcount"
        Me.peanutchilcount.ReadOnly = True
        Me.peanutchilcount.Size = New System.Drawing.Size(100, 64)
        Me.peanutchilcount.TabIndex = 31
        Me.peanutchilcount.Text = "0"
        Me.peanutchilcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hazelchilcofcount
        '
        Me.hazelchilcofcount.Cursor = System.Windows.Forms.Cursors.No
        Me.hazelchilcofcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "p3db", True))
        Me.hazelchilcofcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.hazelchilcofcount.Location = New System.Drawing.Point(154, 425)
        Me.hazelchilcofcount.Name = "hazelchilcofcount"
        Me.hazelchilcofcount.ReadOnly = True
        Me.hazelchilcofcount.Size = New System.Drawing.Size(100, 64)
        Me.hazelchilcofcount.TabIndex = 31
        Me.hazelchilcofcount.Text = "0"
        Me.hazelchilcofcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'caramelchilcofcount
        '
        Me.caramelchilcofcount.Cursor = System.Windows.Forms.Cursors.No
        Me.caramelchilcofcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "p2db", True))
        Me.caramelchilcofcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.caramelchilcofcount.Location = New System.Drawing.Point(154, 264)
        Me.caramelchilcofcount.Name = "caramelchilcofcount"
        Me.caramelchilcofcount.ReadOnly = True
        Me.caramelchilcofcount.Size = New System.Drawing.Size(100, 64)
        Me.caramelchilcofcount.TabIndex = 31
        Me.caramelchilcofcount.Text = "0"
        Me.caramelchilcofcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chocochilcofcount
        '
        Me.chocochilcofcount.Cursor = System.Windows.Forms.Cursors.No
        Me.chocochilcofcount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "p1db", True))
        Me.chocochilcofcount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.chocochilcofcount.Location = New System.Drawing.Point(154, 104)
        Me.chocochilcofcount.Name = "chocochilcofcount"
        Me.chocochilcofcount.ReadOnly = True
        Me.chocochilcofcount.Size = New System.Drawing.Size(100, 64)
        Me.chocochilcofcount.TabIndex = 31
        Me.chocochilcofcount.Text = "0"
        Me.chocochilcofcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'p4lab
        '
        Me.p4lab.AutoSize = True
        Me.p4lab.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p4lab.Location = New System.Drawing.Point(53, 495)
        Me.p4lab.Name = "p4lab"
        Me.p4lab.Size = New System.Drawing.Size(293, 90)
        Me.p4lab.TabIndex = 30
        Me.p4lab.Text = "Peanut-Butter Chilled" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Coffee"
        '
        'peanutchilcofadd
        '
        Me.peanutchilcofadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.peanutchilcofadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peanutchilcofadd.Location = New System.Drawing.Point(259, 588)
        Me.peanutchilcofadd.Name = "peanutchilcofadd"
        Me.peanutchilcofadd.Size = New System.Drawing.Size(111, 64)
        Me.peanutchilcofadd.TabIndex = 28
        Me.peanutchilcofadd.Text = "+"
        Me.peanutchilcofadd.UseVisualStyleBackColor = True
        '
        'p3lab
        '
        Me.p3lab.AutoSize = True
        Me.p3lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p3lab.Location = New System.Drawing.Point(28, 370)
        Me.p3lab.Name = "p3lab"
        Me.p3lab.Size = New System.Drawing.Size(352, 52)
        Me.p3lab.TabIndex = 30
        Me.p3lab.Text = "Hazelnut Chilled Coffee"
        '
        'hazelchilcofadd
        '
        Me.hazelchilcofadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hazelchilcofadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hazelchilcofadd.Location = New System.Drawing.Point(259, 425)
        Me.hazelchilcofadd.Name = "hazelchilcofadd"
        Me.hazelchilcofadd.Size = New System.Drawing.Size(111, 64)
        Me.hazelchilcofadd.TabIndex = 28
        Me.hazelchilcofadd.Text = "+"
        Me.hazelchilcofadd.UseVisualStyleBackColor = True
        '
        'p2lab
        '
        Me.p2lab.AutoSize = True
        Me.p2lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2lab.Location = New System.Drawing.Point(28, 209)
        Me.p2lab.Name = "p2lab"
        Me.p2lab.Size = New System.Drawing.Size(352, 52)
        Me.p2lab.TabIndex = 30
        Me.p2lab.Text = "Caramel Chilled Coffee"
        '
        'peanutchilrem
        '
        Me.peanutchilrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.peanutchilrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peanutchilrem.Location = New System.Drawing.Point(37, 588)
        Me.peanutchilrem.Name = "peanutchilrem"
        Me.peanutchilrem.Size = New System.Drawing.Size(111, 64)
        Me.peanutchilrem.TabIndex = 29
        Me.peanutchilrem.Text = "-"
        Me.peanutchilrem.UseVisualStyleBackColor = True
        '
        'caramelchilcofadd
        '
        Me.caramelchilcofadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caramelchilcofadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caramelchilcofadd.Location = New System.Drawing.Point(259, 264)
        Me.caramelchilcofadd.Name = "caramelchilcofadd"
        Me.caramelchilcofadd.Size = New System.Drawing.Size(111, 64)
        Me.caramelchilcofadd.TabIndex = 28
        Me.caramelchilcofadd.Text = "+"
        Me.caramelchilcofadd.UseVisualStyleBackColor = True
        '
        'hazelchilcofrem
        '
        Me.hazelchilcofrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hazelchilcofrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hazelchilcofrem.Location = New System.Drawing.Point(37, 425)
        Me.hazelchilcofrem.Name = "hazelchilcofrem"
        Me.hazelchilcofrem.Size = New System.Drawing.Size(111, 64)
        Me.hazelchilcofrem.TabIndex = 29
        Me.hazelchilcofrem.Text = "-"
        Me.hazelchilcofrem.UseVisualStyleBackColor = True
        '
        'p1lab
        '
        Me.p1lab.AutoSize = True
        Me.p1lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1lab.Location = New System.Drawing.Point(19, 49)
        Me.p1lab.Name = "p1lab"
        Me.p1lab.Size = New System.Drawing.Size(373, 52)
        Me.p1lab.TabIndex = 30
        Me.p1lab.Text = "Chocolate Chilled Coffee"
        '
        'caramelchilcofrem
        '
        Me.caramelchilcofrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.caramelchilcofrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caramelchilcofrem.Location = New System.Drawing.Point(37, 264)
        Me.caramelchilcofrem.Name = "caramelchilcofrem"
        Me.caramelchilcofrem.Size = New System.Drawing.Size(111, 64)
        Me.caramelchilcofrem.TabIndex = 29
        Me.caramelchilcofrem.Text = "-"
        Me.caramelchilcofrem.UseVisualStyleBackColor = True
        '
        'chocochilcofadd
        '
        Me.chocochilcofadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chocochilcofadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chocochilcofadd.Location = New System.Drawing.Point(259, 104)
        Me.chocochilcofadd.Name = "chocochilcofadd"
        Me.chocochilcofadd.Size = New System.Drawing.Size(111, 64)
        Me.chocochilcofadd.TabIndex = 28
        Me.chocochilcofadd.Text = "+"
        Me.chocochilcofadd.UseVisualStyleBackColor = True
        '
        'chocochilcofrem
        '
        Me.chocochilcofrem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chocochilcofrem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chocochilcofrem.Location = New System.Drawing.Point(37, 104)
        Me.chocochilcofrem.Name = "chocochilcofrem"
        Me.chocochilcofrem.Size = New System.Drawing.Size(111, 64)
        Me.chocochilcofrem.TabIndex = 29
        Me.chocochilcofrem.Text = "-"
        Me.chocochilcofrem.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 25)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Juice"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.raspicedteacount)
        Me.TabPage10.Controls.Add(Me.strawicedteacount)
        Me.TabPage10.Controls.Add(Me.berryicedteacount)
        Me.TabPage10.Controls.Add(Me.t3lab)
        Me.TabPage10.Controls.Add(Me.raspicedteaadd)
        Me.TabPage10.Controls.Add(Me.t2lab)
        Me.TabPage10.Controls.Add(Me.strawicedteaadd)
        Me.TabPage10.Controls.Add(Me.raspicedtearem)
        Me.TabPage10.Controls.Add(Me.t1lab)
        Me.TabPage10.Controls.Add(Me.strawicedtearem)
        Me.TabPage10.Controls.Add(Me.berryicedteaadd)
        Me.TabPage10.Controls.Add(Me.berryicedtearem)
        Me.TabPage10.Location = New System.Drawing.Point(4, 25)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(403, 1072)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Iced Tea"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'raspicedteacount
        '
        Me.raspicedteacount.Cursor = System.Windows.Forms.Cursors.No
        Me.raspicedteacount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "t3db", True))
        Me.raspicedteacount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.raspicedteacount.Location = New System.Drawing.Point(150, 536)
        Me.raspicedteacount.Name = "raspicedteacount"
        Me.raspicedteacount.ReadOnly = True
        Me.raspicedteacount.Size = New System.Drawing.Size(100, 64)
        Me.raspicedteacount.TabIndex = 35
        Me.raspicedteacount.Text = "0"
        Me.raspicedteacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'strawicedteacount
        '
        Me.strawicedteacount.Cursor = System.Windows.Forms.Cursors.No
        Me.strawicedteacount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "t2db", True))
        Me.strawicedteacount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.strawicedteacount.Location = New System.Drawing.Point(150, 332)
        Me.strawicedteacount.Name = "strawicedteacount"
        Me.strawicedteacount.ReadOnly = True
        Me.strawicedteacount.Size = New System.Drawing.Size(100, 64)
        Me.strawicedteacount.TabIndex = 35
        Me.strawicedteacount.Text = "0"
        Me.strawicedteacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'berryicedteacount
        '
        Me.berryicedteacount.Cursor = System.Windows.Forms.Cursors.No
        Me.berryicedteacount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "t1db", True))
        Me.berryicedteacount.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold)
        Me.berryicedteacount.Location = New System.Drawing.Point(150, 136)
        Me.berryicedteacount.Name = "berryicedteacount"
        Me.berryicedteacount.ReadOnly = True
        Me.berryicedteacount.Size = New System.Drawing.Size(100, 64)
        Me.berryicedteacount.TabIndex = 35
        Me.berryicedteacount.Text = "0"
        Me.berryicedteacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't3lab
        '
        Me.t3lab.AutoSize = True
        Me.t3lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t3lab.Location = New System.Drawing.Point(56, 481)
        Me.t3lab.Name = "t3lab"
        Me.t3lab.Size = New System.Drawing.Size(301, 52)
        Me.t3lab.TabIndex = 34
        Me.t3lab.Text = "Raspberry Iced Tea"
        '
        'raspicedteaadd
        '
        Me.raspicedteaadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.raspicedteaadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raspicedteaadd.Location = New System.Drawing.Point(255, 536)
        Me.raspicedteaadd.Name = "raspicedteaadd"
        Me.raspicedteaadd.Size = New System.Drawing.Size(111, 64)
        Me.raspicedteaadd.TabIndex = 32
        Me.raspicedteaadd.Text = "+"
        Me.raspicedteaadd.UseVisualStyleBackColor = True
        '
        't2lab
        '
        Me.t2lab.AutoSize = True
        Me.t2lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2lab.Location = New System.Drawing.Point(42, 277)
        Me.t2lab.Name = "t2lab"
        Me.t2lab.Size = New System.Drawing.Size(320, 52)
        Me.t2lab.TabIndex = 34
        Me.t2lab.Text = "Strawberry Iced Tea"
        '
        'strawicedteaadd
        '
        Me.strawicedteaadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.strawicedteaadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strawicedteaadd.Location = New System.Drawing.Point(255, 332)
        Me.strawicedteaadd.Name = "strawicedteaadd"
        Me.strawicedteaadd.Size = New System.Drawing.Size(111, 64)
        Me.strawicedteaadd.TabIndex = 32
        Me.strawicedteaadd.Text = "+"
        Me.strawicedteaadd.UseVisualStyleBackColor = True
        '
        'raspicedtearem
        '
        Me.raspicedtearem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.raspicedtearem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raspicedtearem.Location = New System.Drawing.Point(33, 536)
        Me.raspicedtearem.Name = "raspicedtearem"
        Me.raspicedtearem.Size = New System.Drawing.Size(111, 64)
        Me.raspicedtearem.TabIndex = 33
        Me.raspicedtearem.Text = "-"
        Me.raspicedtearem.UseVisualStyleBackColor = True
        '
        't1lab
        '
        Me.t1lab.AutoSize = True
        Me.t1lab.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1lab.Location = New System.Drawing.Point(46, 81)
        Me.t1lab.Name = "t1lab"
        Me.t1lab.Size = New System.Drawing.Size(311, 52)
        Me.t1lab.TabIndex = 34
        Me.t1lab.Text = "Very-Berry Iced Tea"
        '
        'strawicedtearem
        '
        Me.strawicedtearem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.strawicedtearem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strawicedtearem.Location = New System.Drawing.Point(33, 332)
        Me.strawicedtearem.Name = "strawicedtearem"
        Me.strawicedtearem.Size = New System.Drawing.Size(111, 64)
        Me.strawicedtearem.TabIndex = 33
        Me.strawicedtearem.Text = "-"
        Me.strawicedtearem.UseVisualStyleBackColor = True
        '
        'berryicedteaadd
        '
        Me.berryicedteaadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.berryicedteaadd.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.berryicedteaadd.Location = New System.Drawing.Point(255, 136)
        Me.berryicedteaadd.Name = "berryicedteaadd"
        Me.berryicedteaadd.Size = New System.Drawing.Size(111, 64)
        Me.berryicedteaadd.TabIndex = 32
        Me.berryicedteaadd.Text = "+"
        Me.berryicedteaadd.UseVisualStyleBackColor = True
        '
        'berryicedtearem
        '
        Me.berryicedtearem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.berryicedtearem.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.berryicedtearem.Location = New System.Drawing.Point(33, 136)
        Me.berryicedtearem.Name = "berryicedtearem"
        Me.berryicedtearem.Size = New System.Drawing.Size(111, 64)
        Me.berryicedtearem.TabIndex = 33
        Me.berryicedtearem.Text = "-"
        Me.berryicedtearem.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Unispace", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(814, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Serving to"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Unispace", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(651, 21)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(487, 120)
        Me.TextBox8.TabIndex = 0
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.DarkGreen
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(651, 183)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(280, 131)
        Me.Button12.TabIndex = 3
        Me.Button12.Text = "Place Order"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Red
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Location = New System.Drawing.Point(859, 320)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(279, 131)
        Me.Button13.TabIndex = 3
        Me.Button13.Text = "Cancel"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.prevorderdb)
        Me.GroupBox3.Controls.Add(Me.neworderbut)
        Me.GroupBox3.Controls.Add(Me.Button12)
        Me.GroupBox3.Controls.Add(Me.Button13)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(4, 604)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1152, 474)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox14)
        Me.GroupBox4.Controls.Add(Me.GroupBox15)
        Me.GroupBox4.Controls.Add(Me.GroupBox13)
        Me.GroupBox4.Controls.Add(Me.GroupBox12)
        Me.GroupBox4.Controls.Add(Me.GroupBox11)
        Me.GroupBox4.Controls.Add(Me.GroupBox10)
        Me.GroupBox4.Controls.Add(Me.GroupBox9)
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(622, 433)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.uicashback)
        Me.GroupBox14.Location = New System.Drawing.Point(316, 276)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(251, 62)
        Me.GroupBox14.TabIndex = 1
        Me.GroupBox14.TabStop = False
        '
        'uicashback
        '
        Me.uicashback.Cursor = System.Windows.Forms.Cursors.No
        Me.uicashback.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "CashBack", True))
        Me.uicashback.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uicashback.Location = New System.Drawing.Point(6, 14)
        Me.uicashback.Name = "uicashback"
        Me.uicashback.ReadOnly = True
        Me.uicashback.Size = New System.Drawing.Size(239, 43)
        Me.uicashback.TabIndex = 0
        Me.uicashback.TabStop = False
        Me.uicashback.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.duechecked)
        Me.GroupBox15.Controls.Add(Me.duetextbox)
        Me.GroupBox15.Controls.Add(Me.due)
        Me.GroupBox15.Location = New System.Drawing.Point(51, 338)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(516, 62)
        Me.GroupBox15.TabIndex = 1
        Me.GroupBox15.TabStop = False
        '
        'duechecked
        '
        Me.duechecked.BackColor = System.Drawing.Color.LightGray
        Me.duechecked.Cursor = System.Windows.Forms.Cursors.No
        Me.duechecked.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "Due", True))
        Me.duechecked.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold)
        Me.duechecked.Location = New System.Drawing.Point(440, 13)
        Me.duechecked.Name = "duechecked"
        Me.duechecked.ReadOnly = True
        Me.duechecked.Size = New System.Drawing.Size(70, 43)
        Me.duechecked.TabIndex = 10001
        Me.duechecked.TabStop = False
        Me.duechecked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'duetextbox
        '
        Me.duetextbox.Cursor = System.Windows.Forms.Cursors.No
        Me.duetextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "CustomerName", True))
        Me.duetextbox.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold)
        Me.duetextbox.Location = New System.Drawing.Point(96, 13)
        Me.duetextbox.Name = "duetextbox"
        Me.duetextbox.ReadOnly = True
        Me.duetextbox.Size = New System.Drawing.Size(338, 43)
        Me.duetextbox.TabIndex = 6001
        Me.duetextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'due
        '
        Me.due.AutoSize = True
        Me.due.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.due.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.due.Location = New System.Drawing.Point(11, 18)
        Me.due.Name = "due"
        Me.due.Size = New System.Drawing.Size(79, 32)
        Me.due.TabIndex = 6002
        Me.due.Text = "Due"
        Me.due.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.due.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Label12)
        Me.GroupBox13.Location = New System.Drawing.Point(51, 276)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(259, 62)
        Me.GroupBox13.TabIndex = 1
        Me.GroupBox13.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 27)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cash Back"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.uicashrec)
        Me.GroupBox12.Location = New System.Drawing.Point(316, 211)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(251, 66)
        Me.GroupBox12.TabIndex = 1
        Me.GroupBox12.TabStop = False
        '
        'uicashrec
        '
        Me.uicashrec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "CashRecieved", True))
        Me.uicashrec.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold)
        Me.uicashrec.Location = New System.Drawing.Point(6, 16)
        Me.uicashrec.Name = "uicashrec"
        Me.uicashrec.Size = New System.Drawing.Size(239, 43)
        Me.uicashrec.TabIndex = 6003
        Me.uicashrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label11)
        Me.GroupBox11.Location = New System.Drawing.Point(51, 213)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(259, 64)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 27)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Cash Recieved"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.uigrandtotal)
        Me.GroupBox10.Location = New System.Drawing.Point(316, 147)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(251, 65)
        Me.GroupBox10.TabIndex = 1
        Me.GroupBox10.TabStop = False
        '
        'uigrandtotal
        '
        Me.uigrandtotal.Cursor = System.Windows.Forms.Cursors.No
        Me.uigrandtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "GrandTotal", True))
        Me.uigrandtotal.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold)
        Me.uigrandtotal.Location = New System.Drawing.Point(6, 14)
        Me.uigrandtotal.Name = "uigrandtotal"
        Me.uigrandtotal.ReadOnly = True
        Me.uigrandtotal.Size = New System.Drawing.Size(239, 43)
        Me.uigrandtotal.TabIndex = 0
        Me.uigrandtotal.TabStop = False
        Me.uigrandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Location = New System.Drawing.Point(51, 147)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(259, 65)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 27)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Grand Total"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.uidiscount)
        Me.GroupBox8.Location = New System.Drawing.Point(316, 83)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(251, 65)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(184, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 44)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "%"
        '
        'uidiscount
        '
        Me.uidiscount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "Discount", True))
        Me.uidiscount.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold)
        Me.uidiscount.Location = New System.Drawing.Point(6, 14)
        Me.uidiscount.Name = "uidiscount"
        Me.uidiscount.Size = New System.Drawing.Size(174, 43)
        Me.uidiscount.TabIndex = 6004
        Me.uidiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Location = New System.Drawing.Point(51, 83)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(259, 65)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 27)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Discount"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.uitotalprice)
        Me.GroupBox6.Location = New System.Drawing.Point(316, 17)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(251, 67)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'uitotalprice
        '
        Me.uitotalprice.Cursor = System.Windows.Forms.Cursors.No
        Me.uitotalprice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LiqfinalBindingSource, "Total", True))
        Me.uitotalprice.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold)
        Me.uitotalprice.Location = New System.Drawing.Point(6, 14)
        Me.uitotalprice.Name = "uitotalprice"
        Me.uitotalprice.ReadOnly = True
        Me.uitotalprice.Size = New System.Drawing.Size(239, 43)
        Me.uitotalprice.TabIndex = 0
        Me.uitotalprice.TabStop = False
        Me.uitotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Location = New System.Drawing.Point(51, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(259, 67)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total"
        '
        'prevorderdb
        '
        Me.prevorderdb.BackColor = System.Drawing.Color.Teal
        Me.prevorderdb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.prevorderdb.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevorderdb.ForeColor = System.Drawing.Color.White
        Me.prevorderdb.Location = New System.Drawing.Point(651, 320)
        Me.prevorderdb.Name = "prevorderdb"
        Me.prevorderdb.Size = New System.Drawing.Size(202, 131)
        Me.prevorderdb.TabIndex = 3
        Me.prevorderdb.Text = "Previous Order"
        Me.prevorderdb.UseVisualStyleBackColor = False
        '
        'neworderbut
        '
        Me.neworderbut.BackColor = System.Drawing.Color.Coral
        Me.neworderbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.neworderbut.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.neworderbut.ForeColor = System.Drawing.Color.White
        Me.neworderbut.Location = New System.Drawing.Point(937, 183)
        Me.neworderbut.Name = "neworderbut"
        Me.neworderbut.Size = New System.Drawing.Size(201, 131)
        Me.neworderbut.TabIndex = 3
        Me.neworderbut.Text = "Panel"
        Me.neworderbut.UseVisualStyleBackColor = False
        '
        'countformtimer
        '
        Me.countformtimer.Enabled = True
        '
        'updateuiinfo
        '
        Me.updateuiinfo.Enabled = True
        Me.updateuiinfo.Interval = 1
        '
        'listviewupdate
        '
        Me.listviewupdate.Interval = 1000
        '
        'LiqfinalTableAdapter
        '
        Me.LiqfinalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.liqfinalTableAdapter = Me.LiqfinalTableAdapter
        Me.TableAdapterManager.UpdateOrder = Touch_Invoice.liqdbaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(21, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(518, 31)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Item Name"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox2.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(545, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(175, 31)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "Rate"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox3.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(726, 35)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(151, 31)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = "Quantity"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox4.Font = New System.Drawing.Font("Unispace", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(883, 35)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(253, 31)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "Total"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Unispace", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(21, 63)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1115, 467)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 4
        Me.ListView1.TabStop = False
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item Name"
        Me.ColumnHeader1.Width = 520
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Rate"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 175
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantity"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 250
        '
        'totalorderbutton
        '
        Me.totalorderbutton.BackColor = System.Drawing.Color.LightSlateGray
        Me.totalorderbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totalorderbutton.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalorderbutton.Location = New System.Drawing.Point(994, 536)
        Me.totalorderbutton.Name = "totalorderbutton"
        Me.totalorderbutton.Size = New System.Drawing.Size(142, 56)
        Me.totalorderbutton.TabIndex = 35
        Me.totalorderbutton.Text = "Total Orders"
        Me.totalorderbutton.UseVisualStyleBackColor = False
        '
        'fromdate
        '
        Me.fromdate.CustomFormat = "dd-MMM-yyyy"
        Me.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromdate.Location = New System.Drawing.Point(850, 555)
        Me.fromdate.Name = "fromdate"
        Me.fromdate.Size = New System.Drawing.Size(131, 22)
        Me.fromdate.TabIndex = 36
        Me.fromdate.Value = New Date(2018, 8, 18, 0, 0, 0, 0)
        Me.fromdate.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(238, 545)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DbfinalDataGridView
        '
        Me.DbfinalDataGridView.AutoGenerateColumns = False
        Me.DbfinalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbfinalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.OrderDateDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.OrderNumberDataGridViewTextBoxColumn, Me.DueDataGridViewTextBoxColumn, Me.DiscountDataGridViewTextBoxColumn, Me.GrandTotalDataGridViewTextBoxColumn, Me.CashRecievedDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.CashBackDataGridViewTextBoxColumn, Me.H1dbDataGridViewTextBoxColumn, Me.H2dbDataGridViewTextBoxColumn, Me.H3dbDataGridViewTextBoxColumn, Me.H4dbDataGridViewTextBoxColumn, Me.H5dbDataGridViewTextBoxColumn, Me.H6dbDataGridViewTextBoxColumn, Me.H7dbDataGridViewTextBoxColumn, Me.C1dbDataGridViewTextBoxColumn, Me.C2dbDataGridViewTextBoxColumn, Me.C3dbDataGridViewTextBoxColumn, Me.C4dbDataGridViewTextBoxColumn, Me.L1dbDataGridViewTextBoxColumn, Me.L2dbDataGridViewTextBoxColumn, Me.L3dbDataGridViewTextBoxColumn, Me.K1dbDataGridViewTextBoxColumn, Me.K2dbDataGridViewTextBoxColumn, Me.K3dbDataGridViewTextBoxColumn, Me.K4dbDataGridViewTextBoxColumn, Me.K5dbDataGridViewTextBoxColumn, Me.K6dbDataGridViewTextBoxColumn, Me.K7dbDataGridViewTextBoxColumn, Me.M1dbDataGridViewTextBoxColumn, Me.M2dbDataGridViewTextBoxColumn, Me.M3dbDataGridViewTextBoxColumn, Me.M4dbDataGridViewTextBoxColumn, Me.M5dbDataGridViewTextBoxColumn, Me.M6dbDataGridViewTextBoxColumn, Me.N1dbDataGridViewTextBoxColumn, Me.N2dbDataGridViewTextBoxColumn, Me.R1dbDataGridViewTextBoxColumn, Me.R2dbDataGridViewTextBoxColumn, Me.R3dbDataGridViewTextBoxColumn, Me.R4dbDataGridViewTextBoxColumn, Me.R5dbDataGridViewTextBoxColumn, Me.P1dbDataGridViewTextBoxColumn, Me.P2dbDataGridViewTextBoxColumn, Me.P3dbDataGridViewTextBoxColumn, Me.P4dbDataGridViewTextBoxColumn, Me.T1dbDataGridViewTextBoxColumn, Me.T2dbDataGridViewTextBoxColumn, Me.T3dbDataGridViewTextBoxColumn, Me.OrderQuantityDataGridViewTextBoxColumn})
        Me.DbfinalDataGridView.DataSource = Me.LiqfinalBindingSource
        Me.DbfinalDataGridView.Location = New System.Drawing.Point(21, 35)
        Me.DbfinalDataGridView.Name = "DbfinalDataGridView"
        Me.DbfinalDataGridView.ReadOnly = True
        Me.DbfinalDataGridView.RowTemplate.Height = 24
        Me.DbfinalDataGridView.Size = New System.Drawing.Size(1115, 495)
        Me.DbfinalDataGridView.TabIndex = 42
        Me.DbfinalDataGridView.Visible = False
        '
        'OrderQuantityDataGridViewTextBoxColumn
        '
        Me.OrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderQuantity"
        Me.OrderQuantityDataGridViewTextBoxColumn.HeaderText = "OrderQuantity"
        Me.OrderQuantityDataGridViewTextBoxColumn.Name = "OrderQuantityDataGridViewTextBoxColumn"
        Me.OrderQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T3dbDataGridViewTextBoxColumn
        '
        Me.T3dbDataGridViewTextBoxColumn.DataPropertyName = "t3db"
        Me.T3dbDataGridViewTextBoxColumn.HeaderText = "t3db"
        Me.T3dbDataGridViewTextBoxColumn.Name = "T3dbDataGridViewTextBoxColumn"
        Me.T3dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T2dbDataGridViewTextBoxColumn
        '
        Me.T2dbDataGridViewTextBoxColumn.DataPropertyName = "t2db"
        Me.T2dbDataGridViewTextBoxColumn.HeaderText = "t2db"
        Me.T2dbDataGridViewTextBoxColumn.Name = "T2dbDataGridViewTextBoxColumn"
        Me.T2dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T1dbDataGridViewTextBoxColumn
        '
        Me.T1dbDataGridViewTextBoxColumn.DataPropertyName = "t1db"
        Me.T1dbDataGridViewTextBoxColumn.HeaderText = "t1db"
        Me.T1dbDataGridViewTextBoxColumn.Name = "T1dbDataGridViewTextBoxColumn"
        Me.T1dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'P4dbDataGridViewTextBoxColumn
        '
        Me.P4dbDataGridViewTextBoxColumn.DataPropertyName = "p4db"
        Me.P4dbDataGridViewTextBoxColumn.HeaderText = "p4db"
        Me.P4dbDataGridViewTextBoxColumn.Name = "P4dbDataGridViewTextBoxColumn"
        Me.P4dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'P3dbDataGridViewTextBoxColumn
        '
        Me.P3dbDataGridViewTextBoxColumn.DataPropertyName = "p3db"
        Me.P3dbDataGridViewTextBoxColumn.HeaderText = "p3db"
        Me.P3dbDataGridViewTextBoxColumn.Name = "P3dbDataGridViewTextBoxColumn"
        Me.P3dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'P2dbDataGridViewTextBoxColumn
        '
        Me.P2dbDataGridViewTextBoxColumn.DataPropertyName = "p2db"
        Me.P2dbDataGridViewTextBoxColumn.HeaderText = "p2db"
        Me.P2dbDataGridViewTextBoxColumn.Name = "P2dbDataGridViewTextBoxColumn"
        Me.P2dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'P1dbDataGridViewTextBoxColumn
        '
        Me.P1dbDataGridViewTextBoxColumn.DataPropertyName = "p1db"
        Me.P1dbDataGridViewTextBoxColumn.HeaderText = "p1db"
        Me.P1dbDataGridViewTextBoxColumn.Name = "P1dbDataGridViewTextBoxColumn"
        Me.P1dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'R5dbDataGridViewTextBoxColumn
        '
        Me.R5dbDataGridViewTextBoxColumn.DataPropertyName = "r5db"
        Me.R5dbDataGridViewTextBoxColumn.HeaderText = "r5db"
        Me.R5dbDataGridViewTextBoxColumn.Name = "R5dbDataGridViewTextBoxColumn"
        Me.R5dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'R4dbDataGridViewTextBoxColumn
        '
        Me.R4dbDataGridViewTextBoxColumn.DataPropertyName = "r4db"
        Me.R4dbDataGridViewTextBoxColumn.HeaderText = "r4db"
        Me.R4dbDataGridViewTextBoxColumn.Name = "R4dbDataGridViewTextBoxColumn"
        Me.R4dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'R3dbDataGridViewTextBoxColumn
        '
        Me.R3dbDataGridViewTextBoxColumn.DataPropertyName = "r3db"
        Me.R3dbDataGridViewTextBoxColumn.HeaderText = "r3db"
        Me.R3dbDataGridViewTextBoxColumn.Name = "R3dbDataGridViewTextBoxColumn"
        Me.R3dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'R2dbDataGridViewTextBoxColumn
        '
        Me.R2dbDataGridViewTextBoxColumn.DataPropertyName = "r2db"
        Me.R2dbDataGridViewTextBoxColumn.HeaderText = "r2db"
        Me.R2dbDataGridViewTextBoxColumn.Name = "R2dbDataGridViewTextBoxColumn"
        Me.R2dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'R1dbDataGridViewTextBoxColumn
        '
        Me.R1dbDataGridViewTextBoxColumn.DataPropertyName = "r1db"
        Me.R1dbDataGridViewTextBoxColumn.HeaderText = "r1db"
        Me.R1dbDataGridViewTextBoxColumn.Name = "R1dbDataGridViewTextBoxColumn"
        Me.R1dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'N2dbDataGridViewTextBoxColumn
        '
        Me.N2dbDataGridViewTextBoxColumn.DataPropertyName = "n2db"
        Me.N2dbDataGridViewTextBoxColumn.HeaderText = "n2db"
        Me.N2dbDataGridViewTextBoxColumn.Name = "N2dbDataGridViewTextBoxColumn"
        Me.N2dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'N1dbDataGridViewTextBoxColumn
        '
        Me.N1dbDataGridViewTextBoxColumn.DataPropertyName = "n1db"
        Me.N1dbDataGridViewTextBoxColumn.HeaderText = "n1db"
        Me.N1dbDataGridViewTextBoxColumn.Name = "N1dbDataGridViewTextBoxColumn"
        Me.N1dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'M6dbDataGridViewTextBoxColumn
        '
        Me.M6dbDataGridViewTextBoxColumn.DataPropertyName = "m6db"
        Me.M6dbDataGridViewTextBoxColumn.HeaderText = "m6db"
        Me.M6dbDataGridViewTextBoxColumn.Name = "M6dbDataGridViewTextBoxColumn"
        Me.M6dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'M5dbDataGridViewTextBoxColumn
        '
        Me.M5dbDataGridViewTextBoxColumn.DataPropertyName = "m5db"
        Me.M5dbDataGridViewTextBoxColumn.HeaderText = "m5db"
        Me.M5dbDataGridViewTextBoxColumn.Name = "M5dbDataGridViewTextBoxColumn"
        Me.M5dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'M4dbDataGridViewTextBoxColumn
        '
        Me.M4dbDataGridViewTextBoxColumn.DataPropertyName = "m4db"
        Me.M4dbDataGridViewTextBoxColumn.HeaderText = "m4db"
        Me.M4dbDataGridViewTextBoxColumn.Name = "M4dbDataGridViewTextBoxColumn"
        Me.M4dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'M3dbDataGridViewTextBoxColumn
        '
        Me.M3dbDataGridViewTextBoxColumn.DataPropertyName = "m3db"
        Me.M3dbDataGridViewTextBoxColumn.HeaderText = "m3db"
        Me.M3dbDataGridViewTextBoxColumn.Name = "M3dbDataGridViewTextBoxColumn"
        Me.M3dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'M2dbDataGridViewTextBoxColumn
        '
        Me.M2dbDataGridViewTextBoxColumn.DataPropertyName = "m2db"
        Me.M2dbDataGridViewTextBoxColumn.HeaderText = "m2db"
        Me.M2dbDataGridViewTextBoxColumn.Name = "M2dbDataGridViewTextBoxColumn"
        Me.M2dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'M1dbDataGridViewTextBoxColumn
        '
        Me.M1dbDataGridViewTextBoxColumn.DataPropertyName = "m1db"
        Me.M1dbDataGridViewTextBoxColumn.HeaderText = "m1db"
        Me.M1dbDataGridViewTextBoxColumn.Name = "M1dbDataGridViewTextBoxColumn"
        Me.M1dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'K7dbDataGridViewTextBoxColumn
        '
        Me.K7dbDataGridViewTextBoxColumn.DataPropertyName = "k7db"
        Me.K7dbDataGridViewTextBoxColumn.HeaderText = "k7db"
        Me.K7dbDataGridViewTextBoxColumn.Name = "K7dbDataGridViewTextBoxColumn"
        Me.K7dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'K6dbDataGridViewTextBoxColumn
        '
        Me.K6dbDataGridViewTextBoxColumn.DataPropertyName = "k6db"
        Me.K6dbDataGridViewTextBoxColumn.HeaderText = "k6db"
        Me.K6dbDataGridViewTextBoxColumn.Name = "K6dbDataGridViewTextBoxColumn"
        Me.K6dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'K5dbDataGridViewTextBoxColumn
        '
        Me.K5dbDataGridViewTextBoxColumn.DataPropertyName = "k5db"
        Me.K5dbDataGridViewTextBoxColumn.HeaderText = "k5db"
        Me.K5dbDataGridViewTextBoxColumn.Name = "K5dbDataGridViewTextBoxColumn"
        Me.K5dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'K4dbDataGridViewTextBoxColumn
        '
        Me.K4dbDataGridViewTextBoxColumn.DataPropertyName = "k4db"
        Me.K4dbDataGridViewTextBoxColumn.HeaderText = "k4db"
        Me.K4dbDataGridViewTextBoxColumn.Name = "K4dbDataGridViewTextBoxColumn"
        Me.K4dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'K3dbDataGridViewTextBoxColumn
        '
        Me.K3dbDataGridViewTextBoxColumn.DataPropertyName = "k3db"
        Me.K3dbDataGridViewTextBoxColumn.HeaderText = "k3db"
        Me.K3dbDataGridViewTextBoxColumn.Name = "K3dbDataGridViewTextBoxColumn"
        Me.K3dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'K2dbDataGridViewTextBoxColumn
        '
        Me.K2dbDataGridViewTextBoxColumn.DataPropertyName = "k2db"
        Me.K2dbDataGridViewTextBoxColumn.HeaderText = "k2db"
        Me.K2dbDataGridViewTextBoxColumn.Name = "K2dbDataGridViewTextBoxColumn"
        Me.K2dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'K1dbDataGridViewTextBoxColumn
        '
        Me.K1dbDataGridViewTextBoxColumn.DataPropertyName = "k1db"
        Me.K1dbDataGridViewTextBoxColumn.HeaderText = "k1db"
        Me.K1dbDataGridViewTextBoxColumn.Name = "K1dbDataGridViewTextBoxColumn"
        Me.K1dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'L3dbDataGridViewTextBoxColumn
        '
        Me.L3dbDataGridViewTextBoxColumn.DataPropertyName = "l3db"
        Me.L3dbDataGridViewTextBoxColumn.HeaderText = "l3db"
        Me.L3dbDataGridViewTextBoxColumn.Name = "L3dbDataGridViewTextBoxColumn"
        Me.L3dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'L2dbDataGridViewTextBoxColumn
        '
        Me.L2dbDataGridViewTextBoxColumn.DataPropertyName = "l2db"
        Me.L2dbDataGridViewTextBoxColumn.HeaderText = "l2db"
        Me.L2dbDataGridViewTextBoxColumn.Name = "L2dbDataGridViewTextBoxColumn"
        Me.L2dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'L1dbDataGridViewTextBoxColumn
        '
        Me.L1dbDataGridViewTextBoxColumn.DataPropertyName = "l1db"
        Me.L1dbDataGridViewTextBoxColumn.HeaderText = "l1db"
        Me.L1dbDataGridViewTextBoxColumn.Name = "L1dbDataGridViewTextBoxColumn"
        Me.L1dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'C4dbDataGridViewTextBoxColumn
        '
        Me.C4dbDataGridViewTextBoxColumn.DataPropertyName = "c4db"
        Me.C4dbDataGridViewTextBoxColumn.HeaderText = "c4db"
        Me.C4dbDataGridViewTextBoxColumn.Name = "C4dbDataGridViewTextBoxColumn"
        Me.C4dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'C3dbDataGridViewTextBoxColumn
        '
        Me.C3dbDataGridViewTextBoxColumn.DataPropertyName = "c3db"
        Me.C3dbDataGridViewTextBoxColumn.HeaderText = "c3db"
        Me.C3dbDataGridViewTextBoxColumn.Name = "C3dbDataGridViewTextBoxColumn"
        Me.C3dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'C2dbDataGridViewTextBoxColumn
        '
        Me.C2dbDataGridViewTextBoxColumn.DataPropertyName = "c2db"
        Me.C2dbDataGridViewTextBoxColumn.HeaderText = "c2db"
        Me.C2dbDataGridViewTextBoxColumn.Name = "C2dbDataGridViewTextBoxColumn"
        Me.C2dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'C1dbDataGridViewTextBoxColumn
        '
        Me.C1dbDataGridViewTextBoxColumn.DataPropertyName = "c1db"
        Me.C1dbDataGridViewTextBoxColumn.HeaderText = "c1db"
        Me.C1dbDataGridViewTextBoxColumn.Name = "C1dbDataGridViewTextBoxColumn"
        Me.C1dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'H7dbDataGridViewTextBoxColumn
        '
        Me.H7dbDataGridViewTextBoxColumn.DataPropertyName = "h7db"
        Me.H7dbDataGridViewTextBoxColumn.HeaderText = "h7db"
        Me.H7dbDataGridViewTextBoxColumn.Name = "H7dbDataGridViewTextBoxColumn"
        Me.H7dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'H6dbDataGridViewTextBoxColumn
        '
        Me.H6dbDataGridViewTextBoxColumn.DataPropertyName = "h6db"
        Me.H6dbDataGridViewTextBoxColumn.HeaderText = "h6db"
        Me.H6dbDataGridViewTextBoxColumn.Name = "H6dbDataGridViewTextBoxColumn"
        Me.H6dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'H5dbDataGridViewTextBoxColumn
        '
        Me.H5dbDataGridViewTextBoxColumn.DataPropertyName = "h5db"
        Me.H5dbDataGridViewTextBoxColumn.HeaderText = "h5db"
        Me.H5dbDataGridViewTextBoxColumn.Name = "H5dbDataGridViewTextBoxColumn"
        Me.H5dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'H4dbDataGridViewTextBoxColumn
        '
        Me.H4dbDataGridViewTextBoxColumn.DataPropertyName = "h4db"
        Me.H4dbDataGridViewTextBoxColumn.HeaderText = "h4db"
        Me.H4dbDataGridViewTextBoxColumn.Name = "H4dbDataGridViewTextBoxColumn"
        Me.H4dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'H3dbDataGridViewTextBoxColumn
        '
        Me.H3dbDataGridViewTextBoxColumn.DataPropertyName = "h3db"
        Me.H3dbDataGridViewTextBoxColumn.HeaderText = "h3db"
        Me.H3dbDataGridViewTextBoxColumn.Name = "H3dbDataGridViewTextBoxColumn"
        Me.H3dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'H2dbDataGridViewTextBoxColumn
        '
        Me.H2dbDataGridViewTextBoxColumn.DataPropertyName = "h2db"
        Me.H2dbDataGridViewTextBoxColumn.HeaderText = "h2db"
        Me.H2dbDataGridViewTextBoxColumn.Name = "H2dbDataGridViewTextBoxColumn"
        Me.H2dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'H1dbDataGridViewTextBoxColumn
        '
        Me.H1dbDataGridViewTextBoxColumn.DataPropertyName = "h1db"
        Me.H1dbDataGridViewTextBoxColumn.HeaderText = "h1db"
        Me.H1dbDataGridViewTextBoxColumn.Name = "H1dbDataGridViewTextBoxColumn"
        Me.H1dbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CashBackDataGridViewTextBoxColumn
        '
        Me.CashBackDataGridViewTextBoxColumn.DataPropertyName = "CashBack"
        Me.CashBackDataGridViewTextBoxColumn.HeaderText = "CashBack"
        Me.CashBackDataGridViewTextBoxColumn.Name = "CashBackDataGridViewTextBoxColumn"
        Me.CashBackDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CashRecievedDataGridViewTextBoxColumn
        '
        Me.CashRecievedDataGridViewTextBoxColumn.DataPropertyName = "CashRecieved"
        Me.CashRecievedDataGridViewTextBoxColumn.HeaderText = "CashRecieved"
        Me.CashRecievedDataGridViewTextBoxColumn.Name = "CashRecievedDataGridViewTextBoxColumn"
        Me.CashRecievedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrandTotalDataGridViewTextBoxColumn
        '
        Me.GrandTotalDataGridViewTextBoxColumn.DataPropertyName = "GrandTotal"
        Me.GrandTotalDataGridViewTextBoxColumn.HeaderText = "GrandTotal"
        Me.GrandTotalDataGridViewTextBoxColumn.Name = "GrandTotalDataGridViewTextBoxColumn"
        Me.GrandTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        Me.DiscountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DueDataGridViewTextBoxColumn
        '
        Me.DueDataGridViewTextBoxColumn.DataPropertyName = "Due"
        Me.DueDataGridViewTextBoxColumn.HeaderText = "Due"
        Me.DueDataGridViewTextBoxColumn.Name = "DueDataGridViewTextBoxColumn"
        Me.DueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderNumberDataGridViewTextBoxColumn
        '
        Me.OrderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber"
        Me.OrderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber"
        Me.OrderNumberDataGridViewTextBoxColumn.Name = "OrderNumberDataGridViewTextBoxColumn"
        Me.OrderNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderDateDataGridViewTextBoxColumn
        '
        Me.OrderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate"
        Me.OrderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate"
        Me.OrderDateDataGridViewTextBoxColumn.Name = "OrderDateDataGridViewTextBoxColumn"
        Me.OrderDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(21, 545)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 21)
        Me.CheckBox1.TabIndex = 43
        Me.CheckBox1.Text = "Search Due"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'dbsearchbox
        '
        Me.dbsearchbox.Location = New System.Drawing.Point(132, 545)
        Me.dbsearchbox.Name = "dbsearchbox"
        Me.dbsearchbox.Size = New System.Drawing.Size(100, 22)
        Me.dbsearchbox.TabIndex = 45
        Me.dbsearchbox.Visible = False
        '
        'recpt
        '
        Me.recpt.Location = New System.Drawing.Point(319, 545)
        Me.recpt.Multiline = True
        Me.recpt.Name = "recpt"
        Me.recpt.Size = New System.Drawing.Size(45, 23)
        Me.recpt.TabIndex = 46
        Me.recpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.recpt)
        Me.GroupBox2.Controls.Add(Me.dbsearchbox)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.DbfinalDataGridView)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.fromdate)
        Me.GroupBox2.Controls.Add(Me.totalorderbutton)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1156, 828)
        Me.GroupBox2.TabIndex = 10000
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order List"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1937, 1102)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Touch Invoice by LeyLance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LiqfinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Liqdbase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DbfinalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents hotcofclick As Button
    Friend WithEvents iceteaclick As Button
    Friend WithEvents juiceclick As Button
    Friend WithEvents premiumchilclick As Button
    Friend WithEvents mocktailclick As Button
    Friend WithEvents lassiclick As Button
    Friend WithEvents lemonclick As Button
    Friend WithEvents milkshakeclick As Button
    Friend WithEvents crusherclick As Button
    Friend WithEvents coldcofclick As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents h1lab As Label
    Friend WithEvents cuppuadd As Button
    Friend WithEvents cuppurem As Button
    Friend WithEvents hazelnutlattecount As TextBox
    Friend WithEvents h6lab As Label
    Friend WithEvents hazelnutlatteadd As Button
    Friend WithEvents h5lab As Label
    Friend WithEvents vanilalatteadd As Button
    Friend WithEvents caramelmacadd As Button
    Friend WithEvents h4lab As Label
    Friend WithEvents blackadd As Button
    Friend WithEvents h3lab As Label
    Friend WithEvents hazelnutlatterem As Button
    Friend WithEvents mochaadd As Button
    Friend WithEvents vanillalatterem As Button
    Friend WithEvents caramelmacrem As Button
    Friend WithEvents h2lab As Label
    Friend WithEvents blackrem As Button
    Friend WithEvents latteadd As Button
    Friend WithEvents mocharem As Button
    Friend WithEvents latterem As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents countformtimer As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents coldcofcount As TextBox
    Friend WithEvents c1lab As Label
    Friend WithEvents coldcofadd As Button
    Friend WithEvents coldcofrem As Button
    Friend WithEvents caramelcoldcofcount As TextBox
    Friend WithEvents vanillacoldcofcount As TextBox
    Friend WithEvents chococoldcofcount As TextBox
    Friend WithEvents c4lab As Label
    Friend WithEvents c3lab As Label
    Friend WithEvents c2lab As Label
    Friend WithEvents caramelcoldcofadd As Button
    Friend WithEvents vanillacoldcofadd As Button
    Friend WithEvents chococoldcofadd As Button
    Friend WithEvents caramelcoldcofrem As Button
    Friend WithEvents vanillacoldcofrem As Button
    Friend WithEvents chococoldcofrem As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents uicashback As TextBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents duetextbox As TextBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents uigrandtotal As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents uidiscount As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents uitotalprice As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents updateuiinfo As Timer

    'Friend WithEvents TableAdapterManager As LiqdbaseTableAdapters.TableAdapterManager2
    Friend WithEvents cuppucount As TextBox
    Friend WithEvents blackcount As TextBox
    Friend WithEvents mochacount As TextBox
    Friend WithEvents lattecount As TextBox
    Friend WithEvents caramelmaccount As TextBox
    Friend WithEvents vanillalattecount As TextBox
    Friend WithEvents h7lab As Label
    Friend WithEvents ferrerocount As TextBox
    Friend WithEvents r5lab As Label
    Friend WithEvents darkchococount As TextBox
    Friend WithEvents r4lab As Label
    Friend WithEvents kitkatcount As TextBox
    Friend WithEvents r3lab As Label
    Friend WithEvents ferreroadd As Button
    Friend WithEvents snickerscount As TextBox
    Friend WithEvents darkchocoadd As Button
    Friend WithEvents r2lab As Label
    Friend WithEvents kitkatadd As Button
    Friend WithEvents ferrerorem As Button
    Friend WithEvents oreocount As TextBox
    Friend WithEvents darkchocorem As Button
    Friend WithEvents snickersadd As Button
    Friend WithEvents kitkatrem As Button
    Friend WithEvents r1lab As Label
    Friend WithEvents snickersrem As Button
    Friend WithEvents oreoadd As Button
    Friend WithEvents oreorem As Button
    Friend WithEvents peanutbuttermilkcount As TextBox
    Friend WithEvents bananamilkcount As TextBox
    Friend WithEvents strawberrymilkcount As TextBox
    Friend WithEvents mangomilkcount As TextBox
    Friend WithEvents chocomilkcount As TextBox
    Friend WithEvents vanillamilkcount As TextBox
    Friend WithEvents m6lab As Label
    Friend WithEvents peanutbuttermilkadd As Button
    Friend WithEvents m5lab As Label
    Friend WithEvents bananamilkadd As Button
    Friend WithEvents m4lab As Label
    Friend WithEvents strawberrymilkadd As Button
    Friend WithEvents m3lab As Label
    Friend WithEvents peanutbuttermilkrem As Button
    Friend WithEvents mangomilkadd As Button
    Friend WithEvents bananamilkrem As Button
    Friend WithEvents m2lab As Label
    Friend WithEvents strawberrymilkrem As Button
    Friend WithEvents chocomilkadd As Button
    Friend WithEvents mangomilkrem As Button
    Friend WithEvents m1lab As Label
    Friend WithEvents chocomilkrem As Button
    Friend WithEvents vanillamilkadd As Button
    Friend WithEvents vanillamilkrem As Button
    Friend WithEvents orangelemoncount As TextBox
    Friend WithEvents lemonmojitocount As TextBox
    Friend WithEvents n2lab As Label
    Friend WithEvents orangelemonadd As Button
    Friend WithEvents n1lab As Label
    Friend WithEvents orangelemonrem As Button
    Friend WithEvents lemonmojitoadd As Button
    Friend WithEvents lemonmojitorem As Button
    Friend WithEvents mangolassicount As TextBox
    Friend WithEvents espressolassicount As TextBox
    Friend WithEvents lassicount As TextBox
    Friend WithEvents l3lab As Label
    Friend WithEvents mangolassiadd As Button
    Friend WithEvents l2lab As Label
    Friend WithEvents espressolassiadd As Button
    Friend WithEvents mangolassirem As Button
    Friend WithEvents l1lab As Label
    Friend WithEvents espressolassirem As Button
    Friend WithEvents lassiadd As Button
    Friend WithEvents lassirem As Button
    Friend WithEvents darkcurrantcount As TextBox
    Friend WithEvents yellowpunchcount As TextBox
    Friend WithEvents bluebersparkcount As TextBox
    Friend WithEvents grapeinvadecount As TextBox
    Friend WithEvents virapplecount As TextBox
    Friend WithEvents virsangriacount As TextBox
    Friend WithEvents virsanfrancount As TextBox
    Friend WithEvents k7lab As Label
    Friend WithEvents darkcurrantadd As Button
    Friend WithEvents k6lab As Label
    Friend WithEvents yellowpunchadd As Button
    Friend WithEvents k5lab As Label
    Friend WithEvents bluebersparkadd As Button
    Friend WithEvents k4lab As Label
    Friend WithEvents grapeinvadeadd As Button
    Friend WithEvents darkcurrantrem As Button
    Friend WithEvents k3lab As Label
    Friend WithEvents yellowpunchrem As Button
    Friend WithEvents virappleadd As Button
    Friend WithEvents bluebersparkrem As Button
    Friend WithEvents k2lab As Label
    Friend WithEvents grapeinvaderem As Button
    Friend WithEvents virsangriaadd As Button
    Friend WithEvents virapplerem As Button
    Friend WithEvents k1lab As Label
    Friend WithEvents virsangriarem As Button
    Friend WithEvents virsanfranadd As Button
    Friend WithEvents virsanfranrem As Button
    Friend WithEvents peanutchilcount As TextBox
    Friend WithEvents hazelchilcofcount As TextBox
    Friend WithEvents caramelchilcofcount As TextBox
    Friend WithEvents chocochilcofcount As TextBox
    Friend WithEvents p4lab As Label
    Friend WithEvents peanutchilcofadd As Button
    Friend WithEvents p3lab As Label
    Friend WithEvents hazelchilcofadd As Button
    Friend WithEvents p2lab As Label
    Friend WithEvents peanutchilrem As Button
    Friend WithEvents caramelchilcofadd As Button
    Friend WithEvents hazelchilcofrem As Button
    Friend WithEvents p1lab As Label
    Friend WithEvents caramelchilcofrem As Button
    Friend WithEvents chocochilcofadd As Button
    Friend WithEvents chocochilcofrem As Button
    Friend WithEvents raspicedteacount As TextBox
    Friend WithEvents strawicedteacount As TextBox
    Friend WithEvents berryicedteacount As TextBox
    Friend WithEvents t3lab As Label
    Friend WithEvents raspicedteaadd As Button
    Friend WithEvents t2lab As Label
    Friend WithEvents strawicedteaadd As Button
    Friend WithEvents raspicedtearem As Button
    Friend WithEvents t1lab As Label
    Friend WithEvents strawicedtearem As Button
    Friend WithEvents berryicedteaadd As Button
    Friend WithEvents berryicedtearem As Button
    Friend WithEvents toggledbase As Button
    Friend WithEvents Refreshbutton As Button
    Friend WithEvents orderlabel As Label
    Friend WithEvents orderno As TextBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents due As CheckBox
    Friend WithEvents uicashrec As TextBox
    Friend WithEvents duechecked As TextBox
    Friend WithEvents todaydate As TextBox
    Friend WithEvents neworderbut As Button
    Friend WithEvents prevorderdb As Button
    Friend WithEvents listviewupdate As Timer
    Friend WithEvents dbidtext As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents Liqdbase As liqdbase
    Friend WithEvents LiqfinalBindingSource As BindingSource
    Friend WithEvents LiqfinalTableAdapter As liqdbaseTableAdapters.liqfinalTableAdapter
    Friend WithEvents TableAdapterManager As liqdbaseTableAdapters.TableAdapterManager
    Friend WithEvents orderquant As TextBox
    Friend WithEvents ordrtoday As TextBox
    Friend WithEvents totordercount As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents totalorderbutton As Button
    Friend WithEvents fromdate As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents DbfinalDataGridView As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrandTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashRecievedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashBackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents H1dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents H2dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents H3dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents H4dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents H5dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents H6dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents H7dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C1dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C2dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C3dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C4dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents L1dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents L2dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents L3dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents K1dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents K2dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents K3dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents K4dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents K5dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents K6dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents K7dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents M1dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents M2dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents M3dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents M4dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents M5dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents M6dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N1dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N2dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents R1dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents R2dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents R3dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents R4dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents R5dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents P1dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents P2dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents P3dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents P4dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents T1dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents T2dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents T3dbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents dbsearchbox As TextBox
    Friend WithEvents recpt As TextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
