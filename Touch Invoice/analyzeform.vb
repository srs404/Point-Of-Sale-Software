Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Public Class analyzeform


    Private Sub analyzeform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        'TODO: This line of code loads data into the 'Liqdbase.liqfinal' table. You can move, or remove it, as needed.
        Form1.LiqfinalTableAdapter.Fill(Me.Liqdbase.liqfinal)
        dbinfoup.Start()


    End Sub

    Private Sub dbinfoup_Tick(sender As Object, e As EventArgs) Handles dbinfoup.Tick
        Try
            dbsum.Text = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                          Where row.Cells(6).FormattedValue.ToString() <> String.Empty
                          Select Convert.ToInt32(row.Cells(6).FormattedValue)
                      ).Sum().ToString
            dbmax.Text = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                          Where row.Cells(6).FormattedValue.ToString() <> String.Empty
                          Select Convert.ToInt32(row.Cells(6).FormattedValue)
                      ).Max().ToString
            dbmin.Text = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                          Where row.Cells(6).FormattedValue.ToString() <> String.Empty
                          Select Convert.ToInt32(row.Cells(6).FormattedValue)
                      ).Min().ToString
            dbavg.Text = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                          Where row.Cells(6).FormattedValue.ToString() <> String.Empty
                          Select Convert.ToInt32(row.Cells(6).FormattedValue)
                          ).Average().ToString

            unittot.Text = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                            Where row.Cells(51).FormattedValue.ToString() <> String.Empty
                            Select Convert.ToInt32(row.Cells(51).FormattedValue)
                          ).Sum().ToString



            'Hot Coffee Section

            Dim h1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(10).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(10).FormattedValue)
                                 ).Sum().ToString
            Dim h2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(11).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(11).FormattedValue)
                                 ).Sum().ToString
            Dim h3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(12).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(12).FormattedValue)
                                 ).Sum().ToString
            Dim h4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(13).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(13).FormattedValue)
                                 ).Sum().ToString
            Dim h5 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(14).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(14).FormattedValue)
                                 ).Sum().ToString
            Dim h6 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(15).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(15).FormattedValue)
                                 ).Sum().ToString
            Dim h7 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(16).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(16).FormattedValue)
                                 ).Sum().ToString
            'Cold Coffee Section

            Dim c1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(17).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(17).FormattedValue)
                                 ).Sum().ToString
            Dim c2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(18).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(18).FormattedValue)
                                 ).Sum().ToString
            Dim c3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(19).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(19).FormattedValue)
                                 ).Sum().ToString
            Dim c4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(20).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(20).FormattedValue)
                                 ).Sum().ToString

            'Lassi Section

            Dim l1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(21).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(21).FormattedValue)
                                 ).Sum().ToString
            Dim l2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(22).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(22).FormattedValue)
                                 ).Sum().ToString
            Dim l3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(23).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(23).FormattedValue)
                                 ).Sum().ToString

            'Mocktail Section

            Dim k1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(24).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(24).FormattedValue)
                                 ).Sum().ToString
            Dim k2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(25).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(25).FormattedValue)
                                 ).Sum().ToString
            Dim k3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(26).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(26).FormattedValue)
                                 ).Sum().ToString
            Dim k4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(27).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(27).FormattedValue)
                                 ).Sum().ToString
            Dim k5 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(28).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(28).FormattedValue)
                                 ).Sum().ToString
            Dim k6 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(29).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(29).FormattedValue)
                                 ).Sum().ToString
            Dim k7 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(30).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(30).FormattedValue)
                                 ).Sum().ToString

            'Milk Shake Section

            Dim m1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(31).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(31).FormattedValue)
                                 ).Sum().ToString
            Dim m2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(32).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(32).FormattedValue)
                                 ).Sum().ToString
            Dim m3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(33).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(33).FormattedValue)
                                 ).Sum().ToString
            Dim m4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(34).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(34).FormattedValue)
                                 ).Sum().ToString
            Dim m5 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(35).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(35).FormattedValue)
                                 ).Sum().ToString
            Dim m6 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(36).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(36).FormattedValue)
                                 ).Sum().ToString

            'Lemonade Section

            Dim n1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(37).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(37).FormattedValue)
                                 ).Sum().ToString
            Dim n2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(38).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(38).FormattedValue)
                                 ).Sum().ToString

            'Crushers Section

            Dim r1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(39).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(39).FormattedValue)
                                 ).Sum().ToString
            Dim r2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(40).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(40).FormattedValue)
                                 ).Sum().ToString
            Dim r3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(41).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(41).FormattedValue)
                                 ).Sum().ToString
            Dim r4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(42).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(42).FormattedValue)
                                 ).Sum().ToString
            Dim r5 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(43).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(43).FormattedValue)
                                 ).Sum().ToString

            'Premium Chilled Coffee Section

            Dim p1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(44).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(44).FormattedValue)
                                 ).Sum().ToString
            Dim p2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(45).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(45).FormattedValue)
                                 ).Sum().ToString
            Dim p3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(46).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(46).FormattedValue)
                                 ).Sum().ToString
            Dim p4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(47).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(47).FormattedValue)
                                 ).Sum().ToString

            'Iced Tea

            Dim t1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(48).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(48).FormattedValue)
                                 ).Sum().ToString
            Dim t2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(49).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(49).FormattedValue)
                                 ).Sum().ToString
            Dim t3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                                 Where row.Cells(50).FormattedValue.ToString() <> String.Empty
                                 Select Convert.ToInt32(row.Cells(50).FormattedValue)
                                 ).Sum().ToString

            'Hot Coffee Compare

            If h1 > h2 And h1 > h3 And h1 > h4 And h1 > h5 And h1 > h6 And h1 > h7 And h1 > c1 And h1 > c2 And h1 > c3 And h1 > c4 And h1 > l1 And h1 > l2 And h1 > l3 And h1 > k1 And h1 > k2 And h1 > k3 And h1 > k4 And h1 > k5 And h1 > k6 And h1 > k7 And h1 > m1 And h1 > m2 And h1 > m3 And h1 > m4 And h1 > m5 And h1 > m6 And h1 > n1 And h1 > n2 And h1 > r1 And h1 > r2 And h1 > r3 And h1 > r4 And h1 > r5 And h1 > p1 And h1 > p2 And h1 > p3 And h1 > p4 And h1 > t1 And h1 > t2 And h1 > t3 Then



                unitname.Text = "H1"
                TextBox1.Text = h1
            ElseIf h2 > h1 And h2 > h3 And h2 > h4 And h2 > h5 And h2 > h6 And h2 > h7 And h2 > c1 And h2 > c2 And h2 > c3 And h2 > c4 And h2 > l1 And h2 > l2 And h2 > l3 And h2 > k1 And h2 > k2 And h2 > k3 And h2 > k4 And h2 > k5 And h2 > k6 And h2 > k7 And h2 > m1 And h2 > m2 And h2 > m3 And h2 > m4 And h2 > m5 And h2 > m6 And h2 > n1 And h2 > n2 And h2 > r1 And h2 > r2 And h2 > r3 And h2 > r4 And h2 > r5 And h2 > p1 And h2 > p2 And h2 > p3 And h2 > p4 And h2 > t1 And h2 > t2 And h2 > t3 Then



                unitname.Text = "H2"
                TextBox1.Text = h2
            ElseIf h3 > h1 And h3 > h2 And h3 > h4 And h3 > h5 And h3 > h6 And h3 > h7 And h3 > c1 And h3 > c2 And h3 > c3 And h3 > c4 And h3 > l1 And h3 > l2 And h3 > l3 And h3 > k1 And h3 > k2 And h3 > k3 And h3 > k4 And h3 > k5 And h3 > k6 And h3 > k7 And h3 > m1 And h3 > m2 And h3 > m3 And h3 > m4 And h3 > m5 And h3 > m6 And h3 > n1 And h3 > n2 And h3 > r1 And h3 > r2 And h3 > r3 And h3 > r4 And h3 > r5 And h3 > p1 And h3 > p2 And h3 > p3 And h3 > p4 And h3 > t1 And h3 > t2 And h3 > t3 Then



                unitname.Text = "H3"
                TextBox1.Text = h3

            ElseIf h4 > h1 And h4 > h2 And h4 > h3 And h4 > h5 And h4 > h6 And h4 > h7 And h4 > c1 And h4 > c2 And h4 > c3 And h4 > c4 And h4 > l1 And h4 > l2 And h4 > l3 And h4 > k1 And h4 > k2 And h4 > k3 And h4 > k4 And h4 > k5 And h4 > k6 And h4 > k7 And h4 > m1 And h4 > m2 And h4 > m3 And h4 > m4 And h4 > m5 And h4 > m6 And h4 > n1 And h4 > n2 And h4 > r1 And h4 > r2 And h4 > r3 And h4 > r4 And h4 > r5 And h4 > p1 And h4 > p2 And h4 > p3 And h4 > p4 And h4 > t1 And h4 > t2 And h4 > t3 Then

                unitname.Text = "H4"
                TextBox1.Text = h4

            ElseIf h5 > h1 And h5 > h2 And h5 > h3 And h5 > h4 And h5 > h6 And h5 > h7 And h5 > c1 And h5 > c2 And h5 > c3 And h5 > c4 And h5 > l1 And h5 > l2 And h5 > l3 And h5 > k1 And h5 > k2 And h5 > k3 And h5 > k4 And h5 > k5 And h5 > k6 And h5 > k7 And h5 > m1 And h5 > m2 And h5 > m3 And h5 > m4 And h5 > m5 And h5 > m6 And h5 > n1 And h5 > n2 And h5 > r1 And h5 > r2 And h5 > r3 And h5 > r4 And h5 > r5 And h5 > p1 And h5 > p2 And h5 > p3 And h5 > p4 And h5 > t1 And h5 > t2 And h5 > t3 Then

                unitname.Text = "H5"
                TextBox1.Text = h5

            ElseIf h6 > h1 And h6 > h2 And h6 > h3 And h6 > h4 And h6 > h5 And h6 > h7 And h6 > c1 And h6 > c2 And h6 > c3 And h6 > c4 And h6 > l1 And h6 > l2 And h6 > l3 And h6 > k1 And h6 > k2 And h6 > k3 And h6 > k4 And h6 > k5 And h6 > k6 And h6 > k7 And h6 > m1 And h6 > m2 And h6 > m3 And h6 > m4 And h6 > m5 And h6 > m6 And h6 > n1 And h6 > n2 And h6 > r1 And h6 > r2 And h6 > r3 And h6 > r4 And h6 > r5 And h6 > p1 And h6 > p2 And h6 > p3 And h6 > p4 And h6 > t1 And h6 > t2 And h6 > t3 Then

                unitname.Text = "H6"
                TextBox1.Text = h6

            ElseIf h7 > h1 And h7 > h2 And h7 > h3 And h7 > h4 And h7 > h5 And h7 > h6 And h7 > c1 And h7 > c2 And h7 > c3 And h7 > c4 And h7 > l1 And h7 > l2 And h7 > l3 And h7 > k1 And h7 > k2 And h7 > k3 And h7 > k4 And h7 > k5 And h7 > k6 And h7 > k7 And h7 > m1 And h7 > m2 And h7 > m3 And h7 > m4 And h7 > m5 And h7 > m6 And h7 > n1 And h7 > n2 And h7 > r1 And h7 > r2 And h7 > r3 And h7 > r4 And h7 > r5 And h7 > p1 And h7 > p2 And h7 > p3 And h7 > p4 And h7 > t1 And h7 > t2 And h7 > t3 Then

                unitname.Text = "H7"
                TextBox1.Text = h7

                'Cold Coffee Compare

            ElseIf c1 > h1 And c1 > h2 And c1 > h3 And c1 > h4 And c1 > h5 And c1 > h6 And c1 > h7 And c1 > c2 And c1 > c3 And c1 > c4 And c1 > l1 And c1 > l2 And c1 > l3 And c1 > k1 And c1 > k2 And c1 > k3 And c1 > k4 And c1 > k5 And c1 > k6 And c1 > k7 And c1 > m1 And c1 > m2 And c1 > m3 And c1 > m4 And c1 > m5 And c1 > m6 And c1 > n1 And c1 > n2 And c1 > r1 And c1 > r2 And c1 > r3 And c1 > r4 And c1 > r5 And c1 > p1 And c1 > p2 And c1 > p3 And c1 > p4 And c1 > t1 And c1 > t2 And c1 > t3 Then

                unitname.Text = "C1"
                TextBox1.Text = c1

            ElseIf c2 > h1 And c2 > h2 And c2 > h3 And c2 > h4 And c2 > h5 And c2 > h6 And c2 > h7 And c2 > c1 And c2 > c3 And c2 > c4 And c2 > l1 And c2 > l2 And c2 > l3 And c2 > k1 And c2 > k2 And c2 > k3 And c2 > k4 And c2 > k5 And c2 > k6 And c2 > k7 And c2 > m1 And c2 > m2 And c2 > m3 And c2 > m4 And c2 > m5 And c2 > m6 And c2 > n1 And c2 > n2 And c2 > r1 And c2 > r2 And c2 > r3 And c2 > r4 And c2 > r5 And c2 > p1 And c2 > p2 And c2 > p3 And c2 > p4 And c2 > t1 And c2 > t2 And c2 > t3 Then

                unitname.Text = "C2"
                TextBox1.Text = c2

            ElseIf c3 > h1 And c3 > h2 And c3 > h3 And c3 > h4 And c3 > h5 And c3 > h6 And c3 > h7 And c3 > c1 And c3 > c2 And c3 > c4 And c3 > l1 And c3 > l2 And c3 > l3 And c3 > k1 And c3 > k2 And c3 > k3 And c3 > k4 And c3 > k5 And c3 > k6 And c3 > k7 And c3 > m1 And c3 > m2 And c3 > m3 And c3 > m4 And c3 > m5 And c3 > m6 And c3 > n1 And c3 > n2 And c3 > r1 And c3 > r2 And c3 > r3 And c3 > r4 And c3 > r5 And c3 > p1 And c3 > p2 And c3 > p3 And c3 > p4 And c3 > t1 And c3 > t2 And c3 > t3 Then

                unitname.Text = "C3"
                TextBox1.Text = c3

            ElseIf c4 > h1 And c4 > h2 And c4 > h3 And c4 > h4 And c4 > h5 And c4 > h6 And c4 > h7 And c4 > c1 And c4 > c2 And c4 > c3 And c4 > l1 And c4 > l2 And c4 > l3 And c4 > k1 And c4 > k2 And c4 > k3 And c4 > k4 And c4 > k5 And c4 > k6 And c4 > k7 And c4 > m1 And c4 > m2 And c4 > m3 And c4 > m4 And c4 > m5 And c4 > m6 And c4 > n1 And c4 > n2 And c4 > r1 And c4 > r2 And c4 > r3 And c4 > r4 And c4 > r5 And c4 > p1 And c4 > p2 And c4 > p3 And c4 > p4 And c4 > t1 And c4 > t2 And c4 > t3 Then

                unitname.Text = "C4"
                TextBox1.Text = c4

                'Lassi Compare

            ElseIf l1 > h1 And l1 > h2 And l1 > h3 And l1 > h4 And l1 > h5 And l1 > h6 And l1 > h7 And l1 > c1 And l1 > c2 And l1 > c3 And l1 > c4 And l1 > l2 And l1 > l3 And l1 > k1 And l1 > k2 And l1 > k3 And l1 > k4 And l1 > k5 And l1 > k6 And l1 > k7 And l1 > m1 And l1 > m2 And l1 > m3 And l1 > m4 And l1 > m5 And l1 > m6 And l1 > n1 And l1 > n2 And l1 > r1 And l1 > r2 And l1 > r3 And l1 > r4 And l1 > r5 And l1 > p1 And l1 > p2 And l1 > p3 And l1 > p4 And l1 > t1 And l1 > t2 And l1 > t3 Then

                unitname.Text = "L1"
                TextBox1.Text = l1

            ElseIf l2 > h1 And l2 > h2 And l2 > h3 And l2 > h4 And l2 > h5 And l2 > h6 And l2 > h7 And l2 > c1 And l2 > c2 And l2 > c3 And l2 > c4 And l2 > l1 And l2 > l3 And l2 > k1 And l2 > k2 And l2 > k3 And l2 > k4 And l2 > k5 And l2 > k6 And l2 > k7 And l2 > m1 And l2 > m2 And l2 > m3 And l2 > m4 And l2 > m5 And l2 > m6 And l2 > n1 And l2 > n2 And l2 > r1 And l2 > r2 And l2 > r3 And l2 > r4 And l2 > r5 And l2 > p1 And l2 > p2 And l2 > p3 And l2 > p4 And l2 > t1 And l2 > t2 And l2 > t3 Then

                unitname.Text = "L2"
                TextBox1.Text = l2

            ElseIf l3 > h1 And l3 > h2 And l3 > h3 And l3 > h4 And l3 > h5 And l3 > h6 And l3 > h7 And l3 > c1 And l3 > c2 And l3 > c3 And l3 > c4 And l3 > l1 And l3 > l2 And l3 > k1 And l3 > k2 And l3 > k3 And l3 > k4 And l3 > k5 And l3 > k6 And l3 > k7 And l3 > m1 And l3 > m2 And l3 > m3 And l3 > m4 And l3 > m5 And l3 > m6 And l3 > n1 And l3 > n2 And l3 > r1 And l3 > r2 And l3 > r3 And l3 > r4 And l3 > r5 And l3 > p1 And l3 > p2 And l3 > p3 And l3 > p4 And l3 > t1 And l3 > t2 And l3 > t3 Then

                unitname.Text = "L3"
                TextBox1.Text = l3

                'Mocktail Compare

            ElseIf k1 > h1 And k1 > h2 And k1 > h3 And k1 > h4 And k1 > h5 And k1 > h6 And k1 > h7 And k1 > c1 And k1 > c2 And k1 > c3 And k1 > c4 And k1 > l1 And k1 > l2 And k1 > l3 And k1 > k2 And k1 > k3 And k1 > k4 And k1 > k5 And k1 > k6 And k1 > k7 And k1 > m1 And k1 > m2 And k1 > m3 And k1 > m4 And k1 > m5 And k1 > m6 And k1 > n1 And k1 > n2 And k1 > r1 And k1 > r2 And k1 > r3 And k1 > r4 And k1 > r5 And k1 > p1 And k1 > p2 And k1 > p3 And k1 > p4 And k1 > t1 And k1 > t2 And k1 > t3 Then

                unitname.Text = "K1"
                TextBox1.Text = k1

            ElseIf k2 > h1 And k2 > h2 And k2 > h3 And k2 > h4 And k2 > h5 And k2 > h6 And k2 > h7 And k2 > c1 And k2 > c2 And k2 > c3 And k2 > c4 And k2 > l1 And k2 > l2 And k2 > l3 And k2 > k1 And k2 > k3 And k2 > k4 And k2 > k5 And k2 > k6 And k2 > k7 And k2 > m1 And k2 > m2 And k2 > m3 And k2 > m4 And k2 > m5 And k2 > m6 And k2 > n1 And k2 > n2 And k2 > r1 And k2 > r2 And k2 > r3 And k2 > r4 And k2 > r5 And k2 > p1 And k2 > p2 And k2 > p3 And k2 > p4 And k2 > t1 And k2 > t2 And k2 > t3 Then

                unitname.Text = "K2"
                TextBox1.Text = k2

            ElseIf k3 > h1 And k3 > h2 And k3 > h3 And k3 > h4 And k3 > h5 And k3 > h6 And k3 > h7 And k3 > c1 And k3 > c2 And k3 > c3 And k3 > c4 And k3 > l1 And k3 > l2 And k3 > l3 And k3 > k1 And k3 > k2 And k3 > k4 And k3 > k5 And k3 > k6 And k3 > k7 And k3 > m1 And k3 > m2 And k3 > m3 And k3 > m4 And k3 > m5 And k3 > m6 And k3 > n1 And k3 > n2 And k3 > r1 And k3 > r2 And k3 > r3 And k3 > r4 And k3 > r5 And k3 > p1 And k3 > p2 And k3 > p3 And k3 > p4 And k3 > t1 And k3 > t2 And k3 > t3 Then

                unitname.Text = "K3"
                TextBox1.Text = k3

            ElseIf k4 > h1 And k4 > h2 And k4 > h3 And k4 > h4 And k4 > h5 And k4 > h6 And k4 > h7 And k4 > c1 And k4 > c2 And k4 > c3 And k4 > c4 And k4 > l1 And k4 > l2 And k4 > l3 And k4 > k1 And k4 > k2 And k4 > k3 And k4 > k5 And k4 > k6 And k4 > k7 And k4 > m1 And k4 > m2 And k4 > m3 And k4 > m4 And k4 > m5 And k4 > m6 And k4 > n1 And k4 > n2 And k4 > r1 And k4 > r2 And k4 > r3 And k4 > r4 And k4 > r5 And k4 > p1 And k4 > p2 And k4 > p3 And k4 > p4 And k4 > t1 And k4 > t2 And k4 > t3 Then

                unitname.Text = "K4"
                TextBox1.Text = k4

            ElseIf k5 > h1 And k5 > h2 And k5 > h3 And k5 > h4 And k5 > h5 And k5 > h6 And k5 > h7 And k5 > c1 And k5 > c2 And k5 > c3 And k5 > c4 And k5 > l1 And k5 > l2 And k5 > l3 And k5 > k1 And k5 > k2 And k5 > k3 And k5 > k4 And k5 > k6 And k5 > k7 And k5 > m1 And k5 > m2 And k5 > m3 And k5 > m4 And k5 > m5 And k5 > m6 And k5 > n1 And k5 > n2 And k5 > r1 And k5 > r2 And k5 > r3 And k5 > r4 And k5 > r5 And k5 > p1 And k5 > p2 And k5 > p3 And k5 > p4 And k5 > t1 And k5 > t2 And k5 > t3 Then

                unitname.Text = "K5"
                TextBox1.Text = k5

            ElseIf k6 > h1 And k6 > h2 And k6 > h3 And k6 > h4 And k6 > h5 And k6 > h6 And k6 > h7 And k6 > c1 And k6 > c2 And k6 > c3 And k6 > c4 And k6 > l1 And k6 > l2 And k6 > l3 And k6 > k1 And k6 > k2 And k6 > k3 And k6 > k4 And k6 > k5 And k6 > k7 And k6 > m1 And k6 > m2 And k6 > m3 And k6 > m4 And k6 > m5 And k6 > m6 And k6 > n1 And k6 > n2 And k6 > r1 And k6 > r2 And k6 > r3 And k6 > r4 And k6 > r5 And k6 > p1 And k6 > p2 And k6 > p3 And k6 > p4 And k6 > t1 And k6 > t2 And k6 > t3 Then

                unitname.Text = "K6"
                TextBox1.Text = k6

            ElseIf k7 > h1 And k7 > h2 And k7 > h3 And k7 > h4 And k7 > h5 And k7 > h6 And k7 > h7 And k7 > c1 And k7 > c2 And k7 > c3 And k7 > c4 And k7 > l1 And k7 > l2 And k7 > l3 And k7 > k1 And k7 > k2 And k7 > k3 And k7 > k4 And k7 > k5 And k7 > k6 And k7 > m1 And k7 > m2 And k7 > m3 And k7 > m4 And k7 > m5 And k7 > m6 And k7 > n1 And k7 > n2 And k7 > r1 And k7 > r2 And k7 > r3 And k7 > r4 And k7 > r5 And k7 > p1 And k7 > p2 And k7 > p3 And k7 > p4 And k7 > t1 And k7 > t2 And k7 > t3 Then

                unitname.Text = "K7"
                TextBox1.Text = k7

                'Milk Shake Compare

            ElseIf m1 > h1 And m1 > h2 And m1 > h3 And m1 > h4 And m1 > h5 And m1 > h6 And m1 > h7 And m1 > c1 And m1 > c2 And m1 > c3 And m1 > c4 And m1 > l1 And m1 > l2 And m1 > l3 And m1 > k1 And m1 > k2 And m1 > k3 And m1 > k4 And m1 > k5 And m1 > k6 And m1 > k7 And m1 > m2 And m1 > m3 And m1 > m4 And m1 > m5 And m1 > m6 And m1 > n1 And m1 > n2 And m1 > r1 And m1 > r2 And m1 > r3 And m1 > r4 And m1 > r5 And m1 > p1 And m1 > p2 And m1 > p3 And m1 > p4 And m1 > t1 And m1 > t2 And m1 > t3 Then

                unitname.Text = "M1"
                TextBox1.Text = m1

            ElseIf m2 > h1 And m2 > h2 And m2 > h3 And m2 > h4 And m2 > h5 And m2 > h6 And m2 > h7 And m2 > c1 And m2 > c2 And m2 > c3 And m2 > c4 And m2 > l1 And m2 > l2 And m2 > l3 And m2 > k1 And m2 > k2 And m2 > k3 And m2 > k4 And m2 > k5 And m2 > k6 And m2 > k7 And m2 > m1 And m2 > m3 And m2 > m4 And m2 > m5 And m2 > m6 And m2 > n1 And m2 > n2 And m2 > r1 And m2 > r2 And m2 > r3 And m2 > r4 And m2 > r5 And m2 > p1 And m2 > p2 And m2 > p3 And m2 > p4 And m2 > t1 And m2 > t2 And m2 > t3 Then

                unitname.Text = "M2"
                TextBox1.Text = m2

            ElseIf m3 > h1 And m3 > h2 And m3 > h3 And m3 > h4 And m3 > h5 And m3 > h6 And m3 > h7 And m3 > c1 And m3 > c2 And m3 > c3 And m3 > c4 And m3 > l1 And m3 > l2 And m3 > l3 And m3 > k1 And m3 > k2 And m3 > k3 And m3 > k4 And m3 > k5 And m3 > k6 And m3 > k7 And m3 > m1 And m3 > m2 And m3 > m4 And m3 > m5 And m3 > m6 And m3 > n1 And m3 > n2 And m3 > r1 And m3 > r2 And m3 > r3 And m3 > r4 And m3 > r5 And m3 > p1 And m3 > p2 And m3 > p3 And m3 > p4 And m3 > t1 And m3 > t2 And m3 > t3 Then

                unitname.Text = "M3"
                TextBox1.Text = m3

            ElseIf m4 > h1 And m4 > h2 And m4 > h3 And m4 > h4 And m4 > h5 And m4 > h6 And m4 > h7 And m4 > c1 And m4 > c2 And m4 > c3 And m4 > c4 And m4 > l1 And m4 > l2 And m4 > l3 And m4 > k1 And m4 > k2 And m4 > k3 And m4 > k4 And m4 > k5 And m4 > k6 And m4 > k7 And m4 > m1 And m4 > m2 And m4 > m3 And m4 > m5 And m4 > m6 And m4 > n1 And m4 > n2 And m4 > r1 And m4 > r2 And m4 > r3 And m4 > r4 And m4 > r5 And m4 > p1 And m4 > p2 And m4 > p3 And m4 > p4 And m4 > t1 And m4 > t2 And m4 > t3 Then

                unitname.Text = "M4"
                TextBox1.Text = m4

            ElseIf m5 > h1 And m5 > h2 And m5 > h3 And m5 > h4 And m5 > h5 And m5 > h6 And m5 > h7 And m5 > c1 And m5 > c2 And m5 > c3 And m5 > c4 And m5 > l1 And m5 > l2 And m5 > l3 And m5 > k1 And m5 > k2 And m5 > k3 And m5 > k4 And m5 > k5 And m5 > k6 And m5 > k7 And m5 > m1 And m5 > m2 And m5 > m3 And m5 > m4 And m5 > m6 And m5 > n1 And m5 > n2 And m5 > r1 And m5 > r2 And m5 > r3 And m5 > r4 And m5 > r5 And m5 > p1 And m5 > p2 And m5 > p3 And m5 > p4 And m5 > t1 And m5 > t2 And m5 > t3 Then

                unitname.Text = "M5"
                TextBox1.Text = m5

            ElseIf m6 > h1 And m6 > h2 And m6 > h3 And m6 > h4 And m6 > h5 And m6 > h6 And m6 > h7 And m6 > c1 And m6 > c2 And m6 > c3 And m6 > c4 And m6 > l1 And m6 > l2 And m6 > l3 And m6 > k1 And m6 > k2 And m6 > k3 And m6 > k4 And m6 > k5 And m6 > k6 And m6 > k7 And m6 > m1 And m6 > m2 And m6 > m3 And m6 > m4 And m6 > m5 And m6 > n1 And m6 > n2 And m6 > r1 And m6 > r2 And m6 > r3 And m6 > r4 And m6 > r5 And m6 > p1 And m6 > p2 And m6 > p3 And m6 > p4 And m6 > t1 And m6 > t2 And m6 > t3 Then

                unitname.Text = "M6"
                TextBox1.Text = m6

                'Lemonade Compare

            ElseIf n1 > h1 And n1 > h2 And n1 > h3 And n1 > h4 And n1 > h5 And n1 > h6 And n1 > h7 And n1 > c1 And n1 > c2 And n1 > c3 And n1 > c4 And n1 > l1 And n1 > l2 And n1 > l3 And n1 > k1 And n1 > k2 And n1 > k3 And n1 > k4 And n1 > k5 And n1 > k6 And n1 > k7 And n1 > m1 And n1 > m2 And n1 > m3 And n1 > m4 And n1 > m5 And n1 > m6 And n1 > n2 And n1 > r1 And n1 > r2 And n1 > r3 And n1 > r4 And n1 > r5 And n1 > p1 And n1 > p2 And n1 > p3 And n1 > p4 And n1 > t1 And n1 > t2 And n1 > t3 Then

                unitname.Text = "N1"
                TextBox1.Text = n1

            ElseIf n2 > h1 And n2 > h2 And n2 > h3 And n2 > h4 And n2 > h5 And n2 > h6 And n2 > h7 And n2 > c1 And n2 > c2 And n2 > c3 And n2 > c4 And n2 > l1 And n2 > l2 And n2 > l3 And n2 > k1 And n2 > k2 And n2 > k3 And n2 > k4 And n2 > k5 And n2 > k6 And n2 > k7 And n2 > m1 And n2 > m2 And n2 > m3 And n2 > m4 And n2 > m5 And n2 > m6 And n2 > n1 And n2 > r1 And n2 > r2 And n2 > r3 And n2 > r4 And n2 > r5 And n2 > p1 And n2 > p2 And n2 > p3 And n2 > p4 And n2 > t1 And n2 > t2 And n2 > t3 Then

                unitname.Text = "N2"
                TextBox1.Text = n2

                'Crushers Compare

            ElseIf r1 > h1 And r1 > h2 And r1 > h3 And r1 > h4 And r1 > h5 And r1 > h6 And r1 > h7 And r1 > c1 And r1 > c2 And r1 > c3 And r1 > c4 And r1 > l1 And r1 > l2 And r1 > l3 And r1 > k1 And r1 > k2 And r1 > k3 And r1 > k4 And r1 > k5 And r1 > k6 And r1 > k7 And r1 > m1 And r1 > m2 And r1 > m3 And r1 > m4 And r1 > m5 And r1 > m6 And r1 > n1 And r1 > n2 And r1 > r2 And r1 > r3 And r1 > r4 And r1 > r5 And r1 > p1 And r1 > p2 And r1 > p3 And r1 > p4 And r1 > t1 And r1 > t2 And r1 > t3 Then

                unitname.Text = "R1"
                TextBox1.Text = r1

            ElseIf r2 > h1 And r2 > h2 And r2 > h3 And r2 > h4 And r2 > h5 And r2 > h6 And r2 > h7 And r2 > c1 And r2 > c2 And r2 > c3 And r2 > c4 And r2 > l1 And r2 > l2 And r2 > l3 And r2 > k1 And r2 > k2 And r2 > k3 And r2 > k4 And r2 > k5 And r2 > k6 And r2 > k7 And r2 > m1 And r2 > m2 And r2 > m3 And r2 > m4 And r2 > m5 And r2 > m6 And r2 > n1 And r2 > n2 And r2 > r1 And r2 > r3 And r2 > r4 And r2 > r5 And r2 > p1 And r2 > p2 And r2 > p3 And r2 > p4 And r2 > t1 And r2 > t2 And r2 > t3 Then

                unitname.Text = "R2"
                TextBox1.Text = r2

            ElseIf r3 > h1 And r3 > h2 And r3 > h3 And r3 > h4 And r3 > h5 And r3 > h6 And r3 > h7 And r3 > c1 And r3 > c2 And r3 > c3 And r3 > c4 And r3 > l1 And r3 > l2 And r3 > l3 And r3 > k1 And r3 > k2 And r3 > k3 And r3 > k4 And r3 > k5 And r3 > k6 And r3 > k7 And r3 > m1 And r3 > m2 And r3 > m3 And r3 > m4 And r3 > m5 And r3 > m6 And r3 > n1 And r3 > n2 And r3 > r1 And r3 > r2 And r3 > r4 And r3 > r5 And r3 > p1 And r3 > p2 And r3 > p3 And r3 > p4 And r3 > t1 And r3 > t2 And r3 > t3 Then

                unitname.Text = "R3"
                TextBox1.Text = r3

            ElseIf r4 > h1 And r4 > h2 And r4 > h3 And r4 > h4 And r4 > h5 And r4 > h6 And r4 > h7 And r4 > c1 And r4 > c2 And r4 > c3 And r4 > c4 And r4 > l1 And r4 > l2 And r4 > l3 And r4 > k1 And r4 > k2 And r4 > k3 And r4 > k4 And r4 > k5 And r4 > k6 And r4 > k7 And r4 > m1 And r4 > m2 And r4 > m3 And r4 > m4 And r4 > m5 And r4 > m6 And r4 > n1 And r4 > n2 And r4 > r1 And r4 > r2 And r4 > r3 And r4 > r5 And r4 > p1 And r4 > p2 And r4 > p3 And r4 > p4 And r4 > t1 And r4 > t2 And r4 > t3 Then

                unitname.Text = "R4"
                TextBox1.Text = r4

            ElseIf r5 > h1 And r5 > h2 And r5 > h3 And r5 > h4 And r5 > h5 And r5 > h6 And r5 > h7 And r5 > c1 And r5 > c2 And r5 > c3 And r5 > c4 And r5 > l1 And r5 > l2 And r5 > l3 And r5 > k1 And r5 > k2 And r5 > k3 And r5 > k4 And r5 > k5 And r5 > k6 And r5 > k7 And r5 > m1 And r5 > m2 And r5 > m3 And r5 > m4 And r5 > m5 And r5 > m6 And r5 > n1 And r5 > n2 And r5 > r1 And r5 > r2 And r5 > r3 And r5 > r4 And r5 > p1 And r5 > p2 And r5 > p3 And r5 > p4 And r5 > t1 And r5 > t2 And r5 > t3 Then

                unitname.Text = "R5"
                TextBox1.Text = r5

                'Premium Chilled Coffee Compare

            ElseIf p1 > h1 And p1 > h2 And p1 > h3 And p1 > h4 And p1 > h5 And p1 > h6 And p1 > h7 And p1 > c1 And p1 > c2 And p1 > c3 And p1 > c4 And p1 > l1 And p1 > l2 And p1 > l3 And p1 > k1 And p1 > k2 And p1 > k3 And p1 > k4 And p1 > k5 And p1 > k6 And p1 > k7 And p1 > m1 And p1 > m2 And p1 > m3 And p1 > m4 And p1 > m5 And p1 > m6 And p1 > n1 And p1 > n2 And p1 > r1 And p1 > r2 And p1 > r3 And p1 > r4 And p1 > r5 And p1 > p2 And p1 > p3 And p1 > p4 And p1 > t1 And p1 > t2 And p1 > t3 Then

                unitname.Text = "P1"
                TextBox1.Text = p1

            ElseIf p2 > h1 And p2 > h2 And p2 > h3 And p2 > h4 And p2 > h5 And p2 > h6 And p2 > h7 And p2 > c1 And p2 > c2 And p2 > c3 And p2 > c4 And p2 > l1 And p2 > l2 And p2 > l3 And p2 > k1 And p2 > k2 And p2 > k3 And p2 > k4 And p2 > k5 And p2 > k6 And p2 > k7 And p2 > m1 And p2 > m2 And p2 > m3 And p2 > m4 And p2 > m5 And p2 > m6 And p2 > n1 And p2 > n2 And p2 > r1 And p2 > r2 And p2 > r3 And p2 > r4 And p2 > r5 And p2 > p1 And p2 > p3 And p2 > p4 And p2 > t1 And p2 > t2 And p2 > t3 Then

                unitname.Text = "P2"
                TextBox1.Text = p2

            ElseIf p3 > h1 And p3 > h2 And p3 > h3 And p3 > h4 And p3 > h5 And p3 > h6 And p3 > h7 And p3 > c1 And p3 > c2 And p3 > c3 And p3 > c4 And p3 > l1 And p3 > l2 And p3 > l3 And p3 > k1 And p3 > k2 And p3 > k3 And p3 > k4 And p3 > k5 And p3 > k6 And p3 > k7 And p3 > m1 And p3 > m2 And p3 > m3 And p3 > m4 And p3 > m5 And p3 > m6 And p3 > n1 And p3 > n2 And p3 > r1 And p3 > r2 And p3 > r3 And p3 > r4 And p3 > r5 And p3 > p1 And p3 > p2 And p3 > p4 And p3 > t1 And p3 > t2 And p3 > t3 Then

                unitname.Text = "P3"
                TextBox1.Text = p3

            ElseIf p4 > h1 And p4 > h2 And p4 > h3 And p4 > h4 And p4 > h5 And p4 > h6 And p4 > h7 And p4 > c1 And p4 > c2 And p4 > c3 And p4 > c4 And p4 > l1 And p4 > l2 And p4 > l3 And p4 > k1 And p4 > k2 And p4 > k3 And p4 > k4 And p4 > k5 And p4 > k6 And p4 > k7 And p4 > m1 And p4 > m2 And p4 > m3 And p4 > m4 And p4 > m5 And p4 > m6 And p4 > n1 And p4 > n2 And p4 > r1 And p4 > r2 And p4 > r3 And p4 > r4 And p4 > r5 And p4 > p1 And p4 > p2 And p4 > p3 And p4 > t1 And p4 > t2 And p4 > t3 Then

                unitname.Text = "P4"
                TextBox1.Text = p4

                'Iced Tea Compare

            ElseIf t1 > h1 And t1 > h2 And t1 > h3 And t1 > h4 And t1 > h5 And t1 > h6 And t1 > h7 And t1 > c1 And t1 > c2 And t1 > c3 And t1 > c4 And t1 > l1 And t1 > l2 And t1 > l3 And t1 > k1 And t1 > k2 And t1 > k3 And t1 > k4 And t1 > k5 And t1 > k6 And t1 > k7 And t1 > m1 And t1 > m2 And t1 > m3 And t1 > m4 And t1 > m5 And t1 > m6 And t1 > n1 And t1 > n2 And t1 > r1 And t1 > r2 And t1 > r3 And t1 > r4 And t1 > r5 And t1 > p1 And t1 > p2 And t1 > p3 And t1 > p4 And t1 > t2 And t1 > t3 Then

                unitname.Text = "T1"
                TextBox1.Text = t1

            ElseIf t2 > h1 And t2 > h2 And t2 > h3 And t2 > h4 And t2 > h5 And t2 > h6 And t2 > h7 And t2 > c1 And t2 > c2 And t2 > c3 And t2 > c4 And t2 > l1 And t2 > l2 And t2 > l3 And t2 > k1 And t2 > k2 And t2 > k3 And t2 > k4 And t2 > k5 And t2 > k6 And t2 > k7 And t2 > m1 And t2 > m2 And t2 > m3 And t2 > m4 And t2 > m5 And t2 > m6 And t2 > n1 And t2 > n2 And t2 > r1 And t2 > r2 And t2 > r3 And t2 > r4 And t2 > r5 And t2 > p1 And t2 > p2 And t2 > p3 And t2 > p4 And t2 > t1 And t2 > t3 Then

                unitname.Text = "T2"
                TextBox1.Text = t2

            ElseIf t3 > h1 And t3 > h2 And t3 > h3 And t3 > h4 And t3 > h5 And t3 > h6 And t3 > h7 And t3 > c1 And t3 > c2 And t3 > c3 And t3 > c4 And t3 > l1 And t3 > l2 And t3 > l3 And t3 > k1 And t3 > k2 And t3 > k3 And t3 > k4 And t3 > k5 And t3 > k6 And t3 > k7 And t3 > m1 And t3 > m2 And t3 > m3 And t3 > m4 And t3 > m5 And t3 > m6 And t3 > n1 And t3 > n2 And t3 > r1 And t3 > r2 And t3 > r3 And t3 > r4 And t3 > r5 And t3 > p1 And t3 > p2 And t3 > p3 And t3 > p4 And t3 > t1 And t3 > t2 Then

                unitname.Text = "T3"
                TextBox1.Text = t3






            End If






        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
    End Sub


    Private Sub highestunit()



        'Hot Coffee Section

        Dim h1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(10).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(10).FormattedValue)
                             ).Sum().ToString
        Dim h2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(11).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(11).FormattedValue)
                             ).Sum().ToString
        Dim h3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(12).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(12).FormattedValue)
                             ).Sum().ToString
        Dim h4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(13).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(13).FormattedValue)
                             ).Sum().ToString
        Dim h5 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(14).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(14).FormattedValue)
                             ).Sum().ToString
        Dim h6 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(15).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(15).FormattedValue)
                             ).Sum().ToString
        Dim h7 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(16).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(16).FormattedValue)
                             ).Sum().ToString
        'Cold Coffee Section

        Dim c1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(17).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(17).FormattedValue)
                             ).Sum().ToString
        Dim c2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(18).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(18).FormattedValue)
                             ).Sum().ToString
        Dim c3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(19).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(19).FormattedValue)
                             ).Sum().ToString
        Dim c4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(20).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(20).FormattedValue)
                             ).Sum().ToString

        'Lassi Section

        Dim l1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(21).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(21).FormattedValue)
                             ).Sum().ToString
        Dim l2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(22).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(22).FormattedValue)
                             ).Sum().ToString
        Dim l3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(23).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(23).FormattedValue)
                             ).Sum().ToString

        'Mocktail Section

        Dim k1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(24).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(24).FormattedValue)
                             ).Sum().ToString
        Dim k2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(25).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(25).FormattedValue)
                             ).Sum().ToString
        Dim k3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(26).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(26).FormattedValue)
                             ).Sum().ToString
        Dim k4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(27).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(27).FormattedValue)
                             ).Sum().ToString
        Dim k5 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(28).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(28).FormattedValue)
                             ).Sum().ToString
        Dim k6 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(29).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(29).FormattedValue)
                             ).Sum().ToString
        Dim k7 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(30).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(30).FormattedValue)
                             ).Sum().ToString

        'Milk Shake Section

        Dim m1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(31).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(31).FormattedValue)
                             ).Sum().ToString
        Dim m2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(32).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(32).FormattedValue)
                             ).Sum().ToString
        Dim m3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(33).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(33).FormattedValue)
                             ).Sum().ToString
        Dim m4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(34).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(34).FormattedValue)
                             ).Sum().ToString
        Dim m5 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(35).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(35).FormattedValue)
                             ).Sum().ToString
        Dim m6 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(36).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(36).FormattedValue)
                             ).Sum().ToString

        'Lemonade Section

        Dim n1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(37).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(37).FormattedValue)
                             ).Sum().ToString
        Dim n2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(38).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(38).FormattedValue)
                             ).Sum().ToString

        'Crushers Section

        Dim r1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(39).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(39).FormattedValue)
                             ).Sum().ToString
        Dim r2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(40).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(40).FormattedValue)
                             ).Sum().ToString
        Dim r3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(41).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(41).FormattedValue)
                             ).Sum().ToString
        Dim r4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(42).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(42).FormattedValue)
                             ).Sum().ToString
        Dim r5 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(43).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(43).FormattedValue)
                             ).Sum().ToString

        'Premium Chilled Coffee Section

        Dim p1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(44).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(44).FormattedValue)
                             ).Sum().ToString
        Dim p2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(45).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(45).FormattedValue)
                             ).Sum().ToString
        Dim p3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(46).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(46).FormattedValue)
                             ).Sum().ToString
        Dim p4 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(47).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(47).FormattedValue)
                             ).Sum().ToString

        'Iced Tea

        Dim t1 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(48).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(48).FormattedValue)
                             ).Sum().ToString
        Dim t2 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(49).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(49).FormattedValue)
                             ).Sum().ToString
        Dim t3 As Integer = (From row As DataGridViewRow In liqfinalDataGridView.Rows
                             Where row.Cells(50).FormattedValue.ToString() <> String.Empty
                             Select Convert.ToInt32(row.Cells(50).FormattedValue)
                             ).Sum().ToString

        'Hot Coffee Compare

        If h1 > h2 And h1 > h3 And h1 > h4 And h1 > h5 And h1 > h6 And h1 > h7 And h1 > c1 And h1 > c2 And h1 > c3 And h1 > c4 And h1 > l1 And h1 > l2 And h1 > l3 And h1 > k1 And h1 > k2 And h1 > k3 And h1 > k4 And h1 > k5 And h1 > k6 And h1 > k7 And h1 > m1 And h1 > m2 And h1 > m3 And h1 > m4 And h1 > m5 And h1 > m6 And h1 > n1 And h1 > n2 And h1 > r1 And h1 > r2 And h1 > r3 And h1 > r4 And h1 > r5 And h1 > p1 And h1 > p2 And h1 > p3 And h1 > p4 And h1 > t1 And h1 > t2 And h1 > t3 Then



            unitname.Text = "H1"
            TextBox1.Text = h1
        ElseIf h2 > h1 And h2 > h3 And h2 > h4 And h2 > h5 And h2 > h6 And h2 > h7 And h2 > c1 And h2 > c2 And h2 > c3 And h2 > c4 And h2 > l1 And h2 > l2 And h2 > l3 And h2 > k1 And h2 > k2 And h2 > k3 And h2 > k4 And h2 > k5 And h2 > k6 And h2 > k7 And h2 > m1 And h2 > m2 And h2 > m3 And h2 > m4 And h2 > m5 And h2 > m6 And h2 > n1 And h2 > n2 And h2 > r1 And h2 > r2 And h2 > r3 And h2 > r4 And h2 > r5 And h2 > p1 And h2 > p2 And h2 > p3 And h2 > p4 And h2 > t1 And h2 > t2 And h2 > t3 Then



            unitname.Text = "H2"
            TextBox1.Text = h2
        ElseIf h3 > h1 And h3 > h2 And h3 > h4 And h3 > h5 And h3 > h6 And h3 > h7 And h3 > c1 And h3 > c2 And h3 > c3 And h3 > c4 And h3 > l1 And h3 > l2 And h3 > l3 And h3 > k1 And h3 > k2 And h3 > k3 And h3 > k4 And h3 > k5 And h3 > k6 And h3 > k7 And h3 > m1 And h3 > m2 And h3 > m3 And h3 > m4 And h3 > m5 And h3 > m6 And h3 > n1 And h3 > n2 And h3 > r1 And h3 > r2 And h3 > r3 And h3 > r4 And h3 > r5 And h3 > p1 And h3 > p2 And h3 > p3 And h3 > p4 And h3 > t1 And h3 > t2 And h3 > t3 Then



            unitname.Text = "H3"
            TextBox1.Text = h3

        ElseIf h4 > h1 And h4 > h2 And h4 > h3 And h4 > h5 And h4 > h6 And h4 > h7 And h4 > c1 And h4 > c2 And h4 > c3 And h4 > c4 And h4 > l1 And h4 > l2 And h4 > l3 And h4 > k1 And h4 > k2 And h4 > k3 And h4 > k4 And h4 > k5 And h4 > k6 And h4 > k7 And h4 > m1 And h4 > m2 And h4 > m3 And h4 > m4 And h4 > m5 And h4 > m6 And h4 > n1 And h4 > n2 And h4 > r1 And h4 > r2 And h4 > r3 And h4 > r4 And h4 > r5 And h4 > p1 And h4 > p2 And h4 > p3 And h4 > p4 And h4 > t1 And h4 > t2 And h4 > t3 Then

            unitname.Text = "H4"
            TextBox1.Text = h4

        ElseIf h5 > h1 And h5 > h2 And h5 > h3 And h5 > h4 And h5 > h6 And h5 > h7 And h5 > c1 And h5 > c2 And h5 > c3 And h5 > c4 And h5 > l1 And h5 > l2 And h5 > l3 And h5 > k1 And h5 > k2 And h5 > k3 And h5 > k4 And h5 > k5 And h5 > k6 And h5 > k7 And h5 > m1 And h5 > m2 And h5 > m3 And h5 > m4 And h5 > m5 And h5 > m6 And h5 > n1 And h5 > n2 And h5 > r1 And h5 > r2 And h5 > r3 And h5 > r4 And h5 > r5 And h5 > p1 And h5 > p2 And h5 > p3 And h5 > p4 And h5 > t1 And h5 > t2 And h5 > t3 Then

            unitname.Text = "H5"
            TextBox1.Text = h5

        ElseIf h6 > h1 And h6 > h2 And h6 > h3 And h6 > h4 And h6 > h5 And h6 > h7 And h6 > c1 And h6 > c2 And h6 > c3 And h6 > c4 And h6 > l1 And h6 > l2 And h6 > l3 And h6 > k1 And h6 > k2 And h6 > k3 And h6 > k4 And h6 > k5 And h6 > k6 And h6 > k7 And h6 > m1 And h6 > m2 And h6 > m3 And h6 > m4 And h6 > m5 And h6 > m6 And h6 > n1 And h6 > n2 And h6 > r1 And h6 > r2 And h6 > r3 And h6 > r4 And h6 > r5 And h6 > p1 And h6 > p2 And h6 > p3 And h6 > p4 And h6 > t1 And h6 > t2 And h6 > t3 Then

            unitname.Text = "H6"
            TextBox1.Text = h6

        ElseIf h7 > h1 And h7 > h2 And h7 > h3 And h7 > h4 And h7 > h5 And h7 > h6 And h7 > c1 And h7 > c2 And h7 > c3 And h7 > c4 And h7 > l1 And h7 > l2 And h7 > l3 And h7 > k1 And h7 > k2 And h7 > k3 And h7 > k4 And h7 > k5 And h7 > k6 And h7 > k7 And h7 > m1 And h7 > m2 And h7 > m3 And h7 > m4 And h7 > m5 And h7 > m6 And h7 > n1 And h7 > n2 And h7 > r1 And h7 > r2 And h7 > r3 And h7 > r4 And h7 > r5 And h7 > p1 And h7 > p2 And h7 > p3 And h7 > p4 And h7 > t1 And h7 > t2 And h7 > t3 Then

            unitname.Text = "H7"
            TextBox1.Text = h7

            'Cold Coffee Compare

        ElseIf c1 > h1 And c1 > h2 And c1 > h3 And c1 > h4 And c1 > h5 And c1 > h6 And c1 > h7 And c1 > c2 And c1 > c3 And c1 > c4 And c1 > l1 And c1 > l2 And c1 > l3 And c1 > k1 And c1 > k2 And c1 > k3 And c1 > k4 And c1 > k5 And c1 > k6 And c1 > k7 And c1 > m1 And c1 > m2 And c1 > m3 And c1 > m4 And c1 > m5 And c1 > m6 And c1 > n1 And c1 > n2 And c1 > r1 And c1 > r2 And c1 > r3 And c1 > r4 And c1 > r5 And c1 > p1 And c1 > p2 And c1 > p3 And c1 > p4 And c1 > t1 And c1 > t2 And c1 > t3 Then

            unitname.Text = "C1"
            TextBox1.Text = c1

        ElseIf c2 > h1 And c2 > h2 And c2 > h3 And c2 > h4 And c2 > h5 And c2 > h6 And c2 > h7 And c2 > c1 And c2 > c3 And c2 > c4 And c2 > l1 And c2 > l2 And c2 > l3 And c2 > k1 And c2 > k2 And c2 > k3 And c2 > k4 And c2 > k5 And c2 > k6 And c2 > k7 And c2 > m1 And c2 > m2 And c2 > m3 And c2 > m4 And c2 > m5 And c2 > m6 And c2 > n1 And c2 > n2 And c2 > r1 And c2 > r2 And c2 > r3 And c2 > r4 And c2 > r5 And c2 > p1 And c2 > p2 And c2 > p3 And c2 > p4 And c2 > t1 And c2 > t2 And c2 > t3 Then

            unitname.Text = "C2"
            TextBox1.Text = c2

        ElseIf c3 > h1 And c3 > h2 And c3 > h3 And c3 > h4 And c3 > h5 And c3 > h6 And c3 > h7 And c3 > c1 And c3 > c2 And c3 > c4 And c3 > l1 And c3 > l2 And c3 > l3 And c3 > k1 And c3 > k2 And c3 > k3 And c3 > k4 And c3 > k5 And c3 > k6 And c3 > k7 And c3 > m1 And c3 > m2 And c3 > m3 And c3 > m4 And c3 > m5 And c3 > m6 And c3 > n1 And c3 > n2 And c3 > r1 And c3 > r2 And c3 > r3 And c3 > r4 And c3 > r5 And c3 > p1 And c3 > p2 And c3 > p3 And c3 > p4 And c3 > t1 And c3 > t2 And c3 > t3 Then

            unitname.Text = "C3"
            TextBox1.Text = c3

        ElseIf c4 > h1 And c4 > h2 And c4 > h3 And c4 > h4 And c4 > h5 And c4 > h6 And c4 > h7 And c4 > c1 And c4 > c2 And c4 > c3 And c4 > l1 And c4 > l2 And c4 > l3 And c4 > k1 And c4 > k2 And c4 > k3 And c4 > k4 And c4 > k5 And c4 > k6 And c4 > k7 And c4 > m1 And c4 > m2 And c4 > m3 And c4 > m4 And c4 > m5 And c4 > m6 And c4 > n1 And c4 > n2 And c4 > r1 And c4 > r2 And c4 > r3 And c4 > r4 And c4 > r5 And c4 > p1 And c4 > p2 And c4 > p3 And c4 > p4 And c4 > t1 And c4 > t2 And c4 > t3 Then

            unitname.Text = "C4"
            TextBox1.Text = c4

            'Lassi Compare

        ElseIf l1 > h1 And l1 > h2 And l1 > h3 And l1 > h4 And l1 > h5 And l1 > h6 And l1 > h7 And l1 > c1 And l1 > c2 And l1 > c3 And l1 > c4 And l1 > l2 And l1 > l3 And l1 > k1 And l1 > k2 And l1 > k3 And l1 > k4 And l1 > k5 And l1 > k6 And l1 > k7 And l1 > m1 And l1 > m2 And l1 > m3 And l1 > m4 And l1 > m5 And l1 > m6 And l1 > n1 And l1 > n2 And l1 > r1 And l1 > r2 And l1 > r3 And l1 > r4 And l1 > r5 And l1 > p1 And l1 > p2 And l1 > p3 And l1 > p4 And l1 > t1 And l1 > t2 And l1 > t3 Then

            unitname.Text = "L1"
            TextBox1.Text = l1

        ElseIf l2 > h1 And l2 > h2 And l2 > h3 And l2 > h4 And l2 > h5 And l2 > h6 And l2 > h7 And l2 > c1 And l2 > c2 And l2 > c3 And l2 > c4 And l2 > l1 And l2 > l3 And l2 > k1 And l2 > k2 And l2 > k3 And l2 > k4 And l2 > k5 And l2 > k6 And l2 > k7 And l2 > m1 And l2 > m2 And l2 > m3 And l2 > m4 And l2 > m5 And l2 > m6 And l2 > n1 And l2 > n2 And l2 > r1 And l2 > r2 And l2 > r3 And l2 > r4 And l2 > r5 And l2 > p1 And l2 > p2 And l2 > p3 And l2 > p4 And l2 > t1 And l2 > t2 And l2 > t3 Then

            unitname.Text = "L2"
            TextBox1.Text = l2

        ElseIf l3 > h1 And l3 > h2 And l3 > h3 And l3 > h4 And l3 > h5 And l3 > h6 And l3 > h7 And l3 > c1 And l3 > c2 And l3 > c3 And l3 > c4 And l3 > l1 And l3 > l2 And l3 > k1 And l3 > k2 And l3 > k3 And l3 > k4 And l3 > k5 And l3 > k6 And l3 > k7 And l3 > m1 And l3 > m2 And l3 > m3 And l3 > m4 And l3 > m5 And l3 > m6 And l3 > n1 And l3 > n2 And l3 > r1 And l3 > r2 And l3 > r3 And l3 > r4 And l3 > r5 And l3 > p1 And l3 > p2 And l3 > p3 And l3 > p4 And l3 > t1 And l3 > t2 And l3 > t3 Then

            unitname.Text = "L3"
            TextBox1.Text = l3

            'Mocktail Compare

        ElseIf k1 > h1 And k1 > h2 And k1 > h3 And k1 > h4 And k1 > h5 And k1 > h6 And k1 > h7 And k1 > c1 And k1 > c2 And k1 > c3 And k1 > c4 And k1 > l1 And k1 > l2 And k1 > l3 And k1 > k2 And k1 > k3 And k1 > k4 And k1 > k5 And k1 > k6 And k1 > k7 And k1 > m1 And k1 > m2 And k1 > m3 And k1 > m4 And k1 > m5 And k1 > m6 And k1 > n1 And k1 > n2 And k1 > r1 And k1 > r2 And k1 > r3 And k1 > r4 And k1 > r5 And k1 > p1 And k1 > p2 And k1 > p3 And k1 > p4 And k1 > t1 And k1 > t2 And k1 > t3 Then

            unitname.Text = "K1"
            TextBox1.Text = k1

        ElseIf k2 > h1 And k2 > h2 And k2 > h3 And k2 > h4 And k2 > h5 And k2 > h6 And k2 > h7 And k2 > c1 And k2 > c2 And k2 > c3 And k2 > c4 And k2 > l1 And k2 > l2 And k2 > l3 And k2 > k1 And k2 > k3 And k2 > k4 And k2 > k5 And k2 > k6 And k2 > k7 And k2 > m1 And k2 > m2 And k2 > m3 And k2 > m4 And k2 > m5 And k2 > m6 And k2 > n1 And k2 > n2 And k2 > r1 And k2 > r2 And k2 > r3 And k2 > r4 And k2 > r5 And k2 > p1 And k2 > p2 And k2 > p3 And k2 > p4 And k2 > t1 And k2 > t2 And k2 > t3 Then

            unitname.Text = "K2"
            TextBox1.Text = k2

        ElseIf k3 > h1 And k3 > h2 And k3 > h3 And k3 > h4 And k3 > h5 And k3 > h6 And k3 > h7 And k3 > c1 And k3 > c2 And k3 > c3 And k3 > c4 And k3 > l1 And k3 > l2 And k3 > l3 And k3 > k1 And k3 > k2 And k3 > k4 And k3 > k5 And k3 > k6 And k3 > k7 And k3 > m1 And k3 > m2 And k3 > m3 And k3 > m4 And k3 > m5 And k3 > m6 And k3 > n1 And k3 > n2 And k3 > r1 And k3 > r2 And k3 > r3 And k3 > r4 And k3 > r5 And k3 > p1 And k3 > p2 And k3 > p3 And k3 > p4 And k3 > t1 And k3 > t2 And k3 > t3 Then

            unitname.Text = "K3"
            TextBox1.Text = k3

        ElseIf k4 > h1 And k4 > h2 And k4 > h3 And k4 > h4 And k4 > h5 And k4 > h6 And k4 > h7 And k4 > c1 And k4 > c2 And k4 > c3 And k4 > c4 And k4 > l1 And k4 > l2 And k4 > l3 And k4 > k1 And k4 > k2 And k4 > k3 And k4 > k5 And k4 > k6 And k4 > k7 And k4 > m1 And k4 > m2 And k4 > m3 And k4 > m4 And k4 > m5 And k4 > m6 And k4 > n1 And k4 > n2 And k4 > r1 And k4 > r2 And k4 > r3 And k4 > r4 And k4 > r5 And k4 > p1 And k4 > p2 And k4 > p3 And k4 > p4 And k4 > t1 And k4 > t2 And k4 > t3 Then

            unitname.Text = "K4"
            TextBox1.Text = k4

        ElseIf k5 > h1 And k5 > h2 And k5 > h3 And k5 > h4 And k5 > h5 And k5 > h6 And k5 > h7 And k5 > c1 And k5 > c2 And k5 > c3 And k5 > c4 And k5 > l1 And k5 > l2 And k5 > l3 And k5 > k1 And k5 > k2 And k5 > k3 And k5 > k4 And k5 > k6 And k5 > k7 And k5 > m1 And k5 > m2 And k5 > m3 And k5 > m4 And k5 > m5 And k5 > m6 And k5 > n1 And k5 > n2 And k5 > r1 And k5 > r2 And k5 > r3 And k5 > r4 And k5 > r5 And k5 > p1 And k5 > p2 And k5 > p3 And k5 > p4 And k5 > t1 And k5 > t2 And k5 > t3 Then

            unitname.Text = "K5"
            TextBox1.Text = k5

        ElseIf k6 > h1 And k6 > h2 And k6 > h3 And k6 > h4 And k6 > h5 And k6 > h6 And k6 > h7 And k6 > c1 And k6 > c2 And k6 > c3 And k6 > c4 And k6 > l1 And k6 > l2 And k6 > l3 And k6 > k1 And k6 > k2 And k6 > k3 And k6 > k4 And k6 > k5 And k6 > k7 And k6 > m1 And k6 > m2 And k6 > m3 And k6 > m4 And k6 > m5 And k6 > m6 And k6 > n1 And k6 > n2 And k6 > r1 And k6 > r2 And k6 > r3 And k6 > r4 And k6 > r5 And k6 > p1 And k6 > p2 And k6 > p3 And k6 > p4 And k6 > t1 And k6 > t2 And k6 > t3 Then

            unitname.Text = "K6"
            TextBox1.Text = k6

        ElseIf k7 > h1 And k7 > h2 And k7 > h3 And k7 > h4 And k7 > h5 And k7 > h6 And k7 > h7 And k7 > c1 And k7 > c2 And k7 > c3 And k7 > c4 And k7 > l1 And k7 > l2 And k7 > l3 And k7 > k1 And k7 > k2 And k7 > k3 And k7 > k4 And k7 > k5 And k7 > k6 And k7 > m1 And k7 > m2 And k7 > m3 And k7 > m4 And k7 > m5 And k7 > m6 And k7 > n1 And k7 > n2 And k7 > r1 And k7 > r2 And k7 > r3 And k7 > r4 And k7 > r5 And k7 > p1 And k7 > p2 And k7 > p3 And k7 > p4 And k7 > t1 And k7 > t2 And k7 > t3 Then

            unitname.Text = "K7"
            TextBox1.Text = k7

            'Milk Shake Compare

        ElseIf m1 > h1 And m1 > h2 And m1 > h3 And m1 > h4 And m1 > h5 And m1 > h6 And m1 > h7 And m1 > c1 And m1 > c2 And m1 > c3 And m1 > c4 And m1 > l1 And m1 > l2 And m1 > l3 And m1 > k1 And m1 > k2 And m1 > k3 And m1 > k4 And m1 > k5 And m1 > k6 And m1 > k7 And m1 > m2 And m1 > m3 And m1 > m4 And m1 > m5 And m1 > m6 And m1 > n1 And m1 > n2 And m1 > r1 And m1 > r2 And m1 > r3 And m1 > r4 And m1 > r5 And m1 > p1 And m1 > p2 And m1 > p3 And m1 > p4 And m1 > t1 And m1 > t2 And m1 > t3 Then

            unitname.Text = "M1"
            TextBox1.Text = m1

        ElseIf m2 > h1 And m2 > h2 And m2 > h3 And m2 > h4 And m2 > h5 And m2 > h6 And m2 > h7 And m2 > c1 And m2 > c2 And m2 > c3 And m2 > c4 And m2 > l1 And m2 > l2 And m2 > l3 And m2 > k1 And m2 > k2 And m2 > k3 And m2 > k4 And m2 > k5 And m2 > k6 And m2 > k7 And m2 > m1 And m2 > m3 And m2 > m4 And m2 > m5 And m2 > m6 And m2 > n1 And m2 > n2 And m2 > r1 And m2 > r2 And m2 > r3 And m2 > r4 And m2 > r5 And m2 > p1 And m2 > p2 And m2 > p3 And m2 > p4 And m2 > t1 And m2 > t2 And m2 > t3 Then

            unitname.Text = "M2"
            TextBox1.Text = m2

        ElseIf m3 > h1 And m3 > h2 And m3 > h3 And m3 > h4 And m3 > h5 And m3 > h6 And m3 > h7 And m3 > c1 And m3 > c2 And m3 > c3 And m3 > c4 And m3 > l1 And m3 > l2 And m3 > l3 And m3 > k1 And m3 > k2 And m3 > k3 And m3 > k4 And m3 > k5 And m3 > k6 And m3 > k7 And m3 > m1 And m3 > m2 And m3 > m4 And m3 > m5 And m3 > m6 And m3 > n1 And m3 > n2 And m3 > r1 And m3 > r2 And m3 > r3 And m3 > r4 And m3 > r5 And m3 > p1 And m3 > p2 And m3 > p3 And m3 > p4 And m3 > t1 And m3 > t2 And m3 > t3 Then

            unitname.Text = "M3"
            TextBox1.Text = m3

        ElseIf m4 > h1 And m4 > h2 And m4 > h3 And m4 > h4 And m4 > h5 And m4 > h6 And m4 > h7 And m4 > c1 And m4 > c2 And m4 > c3 And m4 > c4 And m4 > l1 And m4 > l2 And m4 > l3 And m4 > k1 And m4 > k2 And m4 > k3 And m4 > k4 And m4 > k5 And m4 > k6 And m4 > k7 And m4 > m1 And m4 > m2 And m4 > m3 And m4 > m5 And m4 > m6 And m4 > n1 And m4 > n2 And m4 > r1 And m4 > r2 And m4 > r3 And m4 > r4 And m4 > r5 And m4 > p1 And m4 > p2 And m4 > p3 And m4 > p4 And m4 > t1 And m4 > t2 And m4 > t3 Then

            unitname.Text = "M4"
            TextBox1.Text = m4

        ElseIf m5 > h1 And m5 > h2 And m5 > h3 And m5 > h4 And m5 > h5 And m5 > h6 And m5 > h7 And m5 > c1 And m5 > c2 And m5 > c3 And m5 > c4 And m5 > l1 And m5 > l2 And m5 > l3 And m5 > k1 And m5 > k2 And m5 > k3 And m5 > k4 And m5 > k5 And m5 > k6 And m5 > k7 And m5 > m1 And m5 > m2 And m5 > m3 And m5 > m4 And m5 > m6 And m5 > n1 And m5 > n2 And m5 > r1 And m5 > r2 And m5 > r3 And m5 > r4 And m5 > r5 And m5 > p1 And m5 > p2 And m5 > p3 And m5 > p4 And m5 > t1 And m5 > t2 And m5 > t3 Then

            unitname.Text = "M5"
            TextBox1.Text = m5

        ElseIf m6 > h1 And m6 > h2 And m6 > h3 And m6 > h4 And m6 > h5 And m6 > h6 And m6 > h7 And m6 > c1 And m6 > c2 And m6 > c3 And m6 > c4 And m6 > l1 And m6 > l2 And m6 > l3 And m6 > k1 And m6 > k2 And m6 > k3 And m6 > k4 And m6 > k5 And m6 > k6 And m6 > k7 And m6 > m1 And m6 > m2 And m6 > m3 And m6 > m4 And m6 > m5 And m6 > n1 And m6 > n2 And m6 > r1 And m6 > r2 And m6 > r3 And m6 > r4 And m6 > r5 And m6 > p1 And m6 > p2 And m6 > p3 And m6 > p4 And m6 > t1 And m6 > t2 And m6 > t3 Then

            unitname.Text = "M6"
            TextBox1.Text = m6

            'Lemonade Compare

        ElseIf n1 > h1 And n1 > h2 And n1 > h3 And n1 > h4 And n1 > h5 And n1 > h6 And n1 > h7 And n1 > c1 And n1 > c2 And n1 > c3 And n1 > c4 And n1 > l1 And n1 > l2 And n1 > l3 And n1 > k1 And n1 > k2 And n1 > k3 And n1 > k4 And n1 > k5 And n1 > k6 And n1 > k7 And n1 > m1 And n1 > m2 And n1 > m3 And n1 > m4 And n1 > m5 And n1 > m6 And n1 > n2 And n1 > r1 And n1 > r2 And n1 > r3 And n1 > r4 And n1 > r5 And n1 > p1 And n1 > p2 And n1 > p3 And n1 > p4 And n1 > t1 And n1 > t2 And n1 > t3 Then

            unitname.Text = "N1"
            TextBox1.Text = n1

        ElseIf n2 > h1 And n2 > h2 And n2 > h3 And n2 > h4 And n2 > h5 And n2 > h6 And n2 > h7 And n2 > c1 And n2 > c2 And n2 > c3 And n2 > c4 And n2 > l1 And n2 > l2 And n2 > l3 And n2 > k1 And n2 > k2 And n2 > k3 And n2 > k4 And n2 > k5 And n2 > k6 And n2 > k7 And n2 > m1 And n2 > m2 And n2 > m3 And n2 > m4 And n2 > m5 And n2 > m6 And n2 > n1 And n2 > r1 And n2 > r2 And n2 > r3 And n2 > r4 And n2 > r5 And n2 > p1 And n2 > p2 And n2 > p3 And n2 > p4 And n2 > t1 And n2 > t2 And n2 > t3 Then

            unitname.Text = "N2"
            TextBox1.Text = n2

            'Crushers Compare

        ElseIf r1 > h1 And r1 > h2 And r1 > h3 And r1 > h4 And r1 > h5 And r1 > h6 And r1 > h7 And r1 > c1 And r1 > c2 And r1 > c3 And r1 > c4 And r1 > l1 And r1 > l2 And r1 > l3 And r1 > k1 And r1 > k2 And r1 > k3 And r1 > k4 And r1 > k5 And r1 > k6 And r1 > k7 And r1 > m1 And r1 > m2 And r1 > m3 And r1 > m4 And r1 > m5 And r1 > m6 And r1 > n1 And r1 > n2 And r1 > r2 And r1 > r3 And r1 > r4 And r1 > r5 And r1 > p1 And r1 > p2 And r1 > p3 And r1 > p4 And r1 > t1 And r1 > t2 And r1 > t3 Then

            unitname.Text = "R1"
            TextBox1.Text = r1

        ElseIf r2 > h1 And r2 > h2 And r2 > h3 And r2 > h4 And r2 > h5 And r2 > h6 And r2 > h7 And r2 > c1 And r2 > c2 And r2 > c3 And r2 > c4 And r2 > l1 And r2 > l2 And r2 > l3 And r2 > k1 And r2 > k2 And r2 > k3 And r2 > k4 And r2 > k5 And r2 > k6 And r2 > k7 And r2 > m1 And r2 > m2 And r2 > m3 And r2 > m4 And r2 > m5 And r2 > m6 And r2 > n1 And r2 > n2 And r2 > r1 And r2 > r3 And r2 > r4 And r2 > r5 And r2 > p1 And r2 > p2 And r2 > p3 And r2 > p4 And r2 > t1 And r2 > t2 And r2 > t3 Then

            unitname.Text = "R2"
            TextBox1.Text = r2

        ElseIf r3 > h1 And r3 > h2 And r3 > h3 And r3 > h4 And r3 > h5 And r3 > h6 And r3 > h7 And r3 > c1 And r3 > c2 And r3 > c3 And r3 > c4 And r3 > l1 And r3 > l2 And r3 > l3 And r3 > k1 And r3 > k2 And r3 > k3 And r3 > k4 And r3 > k5 And r3 > k6 And r3 > k7 And r3 > m1 And r3 > m2 And r3 > m3 And r3 > m4 And r3 > m5 And r3 > m6 And r3 > n1 And r3 > n2 And r3 > r1 And r3 > r2 And r3 > r4 And r3 > r5 And r3 > p1 And r3 > p2 And r3 > p3 And r3 > p4 And r3 > t1 And r3 > t2 And r3 > t3 Then

            unitname.Text = "R3"
            TextBox1.Text = r3

        ElseIf r4 > h1 And r4 > h2 And r4 > h3 And r4 > h4 And r4 > h5 And r4 > h6 And r4 > h7 And r4 > c1 And r4 > c2 And r4 > c3 And r4 > c4 And r4 > l1 And r4 > l2 And r4 > l3 And r4 > k1 And r4 > k2 And r4 > k3 And r4 > k4 And r4 > k5 And r4 > k6 And r4 > k7 And r4 > m1 And r4 > m2 And r4 > m3 And r4 > m4 And r4 > m5 And r4 > m6 And r4 > n1 And r4 > n2 And r4 > r1 And r4 > r2 And r4 > r3 And r4 > r5 And r4 > p1 And r4 > p2 And r4 > p3 And r4 > p4 And r4 > t1 And r4 > t2 And r4 > t3 Then

            unitname.Text = "R4"
            TextBox1.Text = r4

        ElseIf r5 > h1 And r5 > h2 And r5 > h3 And r5 > h4 And r5 > h5 And r5 > h6 And r5 > h7 And r5 > c1 And r5 > c2 And r5 > c3 And r5 > c4 And r5 > l1 And r5 > l2 And r5 > l3 And r5 > k1 And r5 > k2 And r5 > k3 And r5 > k4 And r5 > k5 And r5 > k6 And r5 > k7 And r5 > m1 And r5 > m2 And r5 > m3 And r5 > m4 And r5 > m5 And r5 > m6 And r5 > n1 And r5 > n2 And r5 > r1 And r5 > r2 And r5 > r3 And r5 > r4 And r5 > p1 And r5 > p2 And r5 > p3 And r5 > p4 And r5 > t1 And r5 > t2 And r5 > t3 Then

            unitname.Text = "R5"
            TextBox1.Text = r5

            'Premium Chilled Coffee Compare

        ElseIf p1 > h1 And p1 > h2 And p1 > h3 And p1 > h4 And p1 > h5 And p1 > h6 And p1 > h7 And p1 > c1 And p1 > c2 And p1 > c3 And p1 > c4 And p1 > l1 And p1 > l2 And p1 > l3 And p1 > k1 And p1 > k2 And p1 > k3 And p1 > k4 And p1 > k5 And p1 > k6 And p1 > k7 And p1 > m1 And p1 > m2 And p1 > m3 And p1 > m4 And p1 > m5 And p1 > m6 And p1 > n1 And p1 > n2 And p1 > r1 And p1 > r2 And p1 > r3 And p1 > r4 And p1 > r5 And p1 > p2 And p1 > p3 And p1 > p4 And p1 > t1 And p1 > t2 And p1 > t3 Then

            unitname.Text = "P1"
            TextBox1.Text = p1

        ElseIf p2 > h1 And p2 > h2 And p2 > h3 And p2 > h4 And p2 > h5 And p2 > h6 And p2 > h7 And p2 > c1 And p2 > c2 And p2 > c3 And p2 > c4 And p2 > l1 And p2 > l2 And p2 > l3 And p2 > k1 And p2 > k2 And p2 > k3 And p2 > k4 And p2 > k5 And p2 > k6 And p2 > k7 And p2 > m1 And p2 > m2 And p2 > m3 And p2 > m4 And p2 > m5 And p2 > m6 And p2 > n1 And p2 > n2 And p2 > r1 And p2 > r2 And p2 > r3 And p2 > r4 And p2 > r5 And p2 > p1 And p2 > p3 And p2 > p4 And p2 > t1 And p2 > t2 And p2 > t3 Then

            unitname.Text = "P2"
            TextBox1.Text = p2

        ElseIf p3 > h1 And p3 > h2 And p3 > h3 And p3 > h4 And p3 > h5 And p3 > h6 And p3 > h7 And p3 > c1 And p3 > c2 And p3 > c3 And p3 > c4 And p3 > l1 And p3 > l2 And p3 > l3 And p3 > k1 And p3 > k2 And p3 > k3 And p3 > k4 And p3 > k5 And p3 > k6 And p3 > k7 And p3 > m1 And p3 > m2 And p3 > m3 And p3 > m4 And p3 > m5 And p3 > m6 And p3 > n1 And p3 > n2 And p3 > r1 And p3 > r2 And p3 > r3 And p3 > r4 And p3 > r5 And p3 > p1 And p3 > p2 And p3 > p4 And p3 > t1 And p3 > t2 And p3 > t3 Then

            unitname.Text = "P3"
            TextBox1.Text = p3

        ElseIf p4 > h1 And p4 > h2 And p4 > h3 And p4 > h4 And p4 > h5 And p4 > h6 And p4 > h7 And p4 > c1 And p4 > c2 And p4 > c3 And p4 > c4 And p4 > l1 And p4 > l2 And p4 > l3 And p4 > k1 And p4 > k2 And p4 > k3 And p4 > k4 And p4 > k5 And p4 > k6 And p4 > k7 And p4 > m1 And p4 > m2 And p4 > m3 And p4 > m4 And p4 > m5 And p4 > m6 And p4 > n1 And p4 > n2 And p4 > r1 And p4 > r2 And p4 > r3 And p4 > r4 And p4 > r5 And p4 > p1 And p4 > p2 And p4 > p3 And p4 > t1 And p4 > t2 And p4 > t3 Then

            unitname.Text = "P4"
            TextBox1.Text = p4

            'Iced Tea Compare

        ElseIf t1 > h1 And t1 > h2 And t1 > h3 And t1 > h4 And t1 > h5 And t1 > h6 And t1 > h7 And t1 > c1 And t1 > c2 And t1 > c3 And t1 > c4 And t1 > l1 And t1 > l2 And t1 > l3 And t1 > k1 And t1 > k2 And t1 > k3 And t1 > k4 And t1 > k5 And t1 > k6 And t1 > k7 And t1 > m1 And t1 > m2 And t1 > m3 And t1 > m4 And t1 > m5 And t1 > m6 And t1 > n1 And t1 > n2 And t1 > r1 And t1 > r2 And t1 > r3 And t1 > r4 And t1 > r5 And t1 > p1 And t1 > p2 And t1 > p3 And t1 > p4 And t1 > t2 And t1 > t3 Then

            unitname.Text = "T1"
            TextBox1.Text = t1

        ElseIf t2 > h1 And t2 > h2 And t2 > h3 And t2 > h4 And t2 > h5 And t2 > h6 And t2 > h7 And t2 > c1 And t2 > c2 And t2 > c3 And t2 > c4 And t2 > l1 And t2 > l2 And t2 > l3 And t2 > k1 And t2 > k2 And t2 > k3 And t2 > k4 And t2 > k5 And t2 > k6 And t2 > k7 And t2 > m1 And t2 > m2 And t2 > m3 And t2 > m4 And t2 > m5 And t2 > m6 And t2 > n1 And t2 > n2 And t2 > r1 And t2 > r2 And t2 > r3 And t2 > r4 And t2 > r5 And t2 > p1 And t2 > p2 And t2 > p3 And t2 > p4 And t2 > t1 And t2 > t3 Then

            unitname.Text = "T2"
            TextBox1.Text = t2

        ElseIf t3 > h1 And t3 > h2 And t3 > h3 And t3 > h4 And t3 > h5 And t3 > h6 And t3 > h7 And t3 > c1 And t3 > c2 And t3 > c3 And t3 > c4 And t3 > l1 And t3 > l2 And t3 > l3 And t3 > k1 And t3 > k2 And t3 > k3 And t3 > k4 And t3 > k5 And t3 > k6 And t3 > k7 And t3 > m1 And t3 > m2 And t3 > m3 And t3 > m4 And t3 > m5 And t3 > m6 And t3 > n1 And t3 > n2 And t3 > r1 And t3 > r2 And t3 > r3 And t3 > r4 And t3 > r5 And t3 > p1 And t3 > p2 And t3 > p3 And t3 > p4 And t3 > t1 And t3 > t2 Then

            unitname.Text = "T3"
            TextBox1.Text = t3






        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Dim mprinter As New myPrinter
        'mprinter.print(unittot.Text)


        LiqfinalBindingSource.Filter = String.Format("OrderDate >= #{0:dd/MMM/yy}# And OrderDate <= #{1:dd/MMM/yy}#", fromdate.Value, todate.Value)
        With liqfinalDataGridView
            .DataSource = LiqfinalBindingSource
        End With


    End Sub

    Private Sub dbsearchbox_TextChanged(sender As Object, e As EventArgs) Handles dbsearchbox.TextChanged

        If dbsearchbox.Text = Nothing Then

            LiqfinalBindingSource.RemoveFilter()

            duecheck.Checked = False

        Else

            Try
                LiqfinalBindingSource.Filter = "(CustomerName LIKE '" & dbsearchbox.Text & "') or (OrderNumber LIKE '" & dbsearchbox.Text & "')"

                With liqfinalDataGridView
                    .DataSource = LiqfinalBindingSource
                End With
            Catch ex As Exception
            End Try



        End If



    End Sub

    Private Sub duecheck_CheckedChanged(sender As Object, e As EventArgs) Handles duecheck.CheckedChanged
        If duecheck.Checked = True Then
            Try
                LiqfinalBindingSource.Filter = "(Due LIKE 'Due')"

                With liqfinalDataGridView
                    .DataSource = LiqfinalBindingSource
                End With
            Catch ex As Exception

            End Try
        Else
            LiqfinalBindingSource.RemoveFilter()


        End If
    End Sub

    Private Sub fromdate_ValueChanged(sender As Object, e As EventArgs) Handles fromdate.ValueChanged
        If fromdate.Value > todate.Value Then
            MsgBox("From Date Can't be from the future!")
            todate.Value = DateTime.Now.ToString("dd-MMM-yyyy")
            fromdate.Value = DateTime.Now.ToString("dd-MMM-yyyy")

            LiqfinalBindingSource.RemoveFilter()
        Else
            LiqfinalBindingSource.Filter = String.Format("OrderDate >= #{0:dd/MMM/yy}# And OrderDate <= #{1:dd/MMM/yy}#", fromdate.Value, todate.Value)
            With liqfinalDataGridView
                .DataSource = LiqfinalBindingSource
            End With
        End If
    End Sub

    Private Sub todate_ValueChanged(sender As Object, e As EventArgs) Handles todate.ValueChanged
        If fromdate.Value > todate.Value Then
            MsgBox("From Date Can't be from the future!")
            todate.Value = DateTime.Now.ToString("dd-MMM-yyyy")
            fromdate.Value = DateTime.Now.ToString("dd-MMM-yyyy")

            LiqfinalBindingSource.RemoveFilter()
        Else
            LiqfinalBindingSource.Filter = String.Format("OrderDate >= #{0:dd/MMM/yy}# And OrderDate <= #{1:dd/MMM/yy}#", fromdate.Value, todate.Value)
            With liqfinalDataGridView
                .DataSource = LiqfinalBindingSource
            End With
        End If
    End Sub


End Class


