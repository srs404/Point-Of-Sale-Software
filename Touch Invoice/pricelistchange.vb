Public Class pricelistchange
    Private Sub pricelistchange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        'Hot Coffee
        h1.Text = My.Settings.h1
        h2.Text = My.Settings.h2
        h3.Text = My.Settings.h3
        h4.Text = My.Settings.h4
        h5.Text = My.Settings.h5
        h6.Text = My.Settings.h6
        h7.Text = My.Settings.h7

        'Cold Coffee
        c1.Text = My.Settings.c1
        c2.Text = My.Settings.c2
        c3.Text = My.Settings.c3
        c4.Text = My.Settings.c4

        'Lassi
        l1.Text = My.Settings.l1
        l2.Text = My.Settings.l2
        l3.Text = My.Settings.l3

        'Mocktail
        k1.Text = My.Settings.k1
        k2.Text = My.Settings.k2
        k3.Text = My.Settings.k3
        k4.Text = My.Settings.k4
        k5.Text = My.Settings.k5
        k6.Text = My.Settings.k6
        k7.Text = My.Settings.k7

        'Milkshake
        m1.Text = My.Settings.m1
        m2.Text = My.Settings.m2
        m3.Text = My.Settings.m3
        m4.Text = My.Settings.m4
        m5.Text = My.Settings.m5
        m6.Text = My.Settings.m6

        'Lemonade
        n1.Text = My.Settings.n1
        n2.Text = My.Settings.n2

        'Crusher
        r1.Text = My.Settings.r1
        r2.Text = My.Settings.r2
        r3.Text = My.Settings.r3
        r4.Text = My.Settings.r4
        r5.Text = My.Settings.r5

        'Premium Chilled Coffee
        p1.Text = My.Settings.p1
        p2.Text = My.Settings.p2
        p3.Text = My.Settings.p3
        p4.Text = My.Settings.p4

        'Iced Tea
        t1.Text = My.Settings.t1
        t2.Text = My.Settings.t2
        t3.Text = My.Settings.t3
    End Sub

    Private Sub exitform_Click(sender As Object, e As EventArgs) Handles exitform.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Hot Coffee
        If h1.Text.Trim.Length <> Nothing Then
            My.Settings.h1 = h1.Text.Replace(" ", "")
            h1.Text = My.Settings.h1

        Else
            h1.Text = My.Settings.h1
        End If

        If h2.Text.Trim.Length <> Nothing Then
            My.Settings.h2 = h2.Text.Replace(" ", "")
            h2.Text = My.Settings.h2
        Else
            h2.Text = My.Settings.h2
        End If

        If h3.Text.Trim.Length <> Nothing Then
            My.Settings.h3 = h3.Text.Replace(" ", "")
            h3.Text = My.Settings.h3
        Else
            h3.Text = My.Settings.h3
        End If

        If h4.Text.Trim.Length <> Nothing Then
            My.Settings.h4 = h4.Text.Replace(" ", "")
            h4.Text = My.Settings.h4
        Else
            h4.Text = My.Settings.h4
        End If

        If h5.Text.Trim.Length <> Nothing Then
            My.Settings.h5 = h5.Text.Replace(" ", "")
            h5.Text = My.Settings.h5
        Else
            h5.Text = My.Settings.h5
        End If

        If h6.Text.Trim.Length <> Nothing Then
            My.Settings.h6 = h6.Text.Replace(" ", "")
            h6.Text = My.Settings.h6
        Else
            h6.Text = My.Settings.h6
        End If

        If h7.Text.Trim.Length <> Nothing Then
            My.Settings.h7 = h7.Text.Replace(" ", "")
            h7.Text = My.Settings.h7
        Else
            h7.Text = My.Settings.h7
        End If

        'Cold Coffee

        If c1.Text.Trim.Length <> Nothing Then
            My.Settings.c1 = c1.Text.Replace(" ", "")
            c1.Text = My.Settings.c1
        Else
            c1.Text = My.Settings.c1
        End If

        If c2.Text.Trim.Length <> Nothing Then
            My.Settings.c2 = c2.Text.Replace(" ", "")
            c2.Text = My.Settings.c2
        Else
            c2.Text = My.Settings.c2
        End If

        If c3.Text.Trim.Length <> Nothing Then
            My.Settings.c3 = c3.Text.Replace(" ", "")
            c3.Text = My.Settings.c3
        Else
            c3.Text = My.Settings.c3
        End If

        If c4.Text.Trim.Length <> Nothing Then
            My.Settings.c4 = c4.Text.Replace(" ", "")
            c4.Text = My.Settings.c4
        Else
            c4.Text = My.Settings.c4
        End If

        'Lassi

        If l1.Text.Trim.Length <> Nothing Then
            My.Settings.l1 = l1.Text.Replace(" ", "")
            l1.Text = My.Settings.l1
        Else
            l1.Text = My.Settings.l1
        End If

        If l2.Text.Trim.Length <> Nothing Then
            My.Settings.l2 = l2.Text.Replace(" ", "")
            l2.Text = My.Settings.l2
        Else
            l2.Text = My.Settings.l2
        End If

        If l3.Text.Trim.Length <> Nothing Then
            My.Settings.l3 = l3.Text.Replace(" ", "")
            l3.Text = My.Settings.l3
        Else
            l3.Text = My.Settings.l3
        End If

        'Mocktail

        If k1.Text.Trim.Length <> Nothing Then
            My.Settings.k1 = k1.Text.Replace(" ", "")
            k1.Text = My.Settings.k1
        Else
            k1.Text = My.Settings.k1
        End If

        If k2.Text.Trim.Length <> Nothing Then
            My.Settings.k2 = k2.Text.Replace(" ", "")
            k2.Text = My.Settings.k2
        Else
            k2.Text = My.Settings.k2
        End If

        If k3.Text.Trim.Length <> Nothing Then
            My.Settings.k3 = k3.Text.Replace(" ", "")
            k3.Text = My.Settings.k3
        Else
            k3.Text = My.Settings.k3
        End If

        If k4.Text.Trim.Length <> Nothing Then
            My.Settings.k4 = k4.Text.Replace(" ", "")
            k4.Text = My.Settings.k4
        Else
            k4.Text = My.Settings.k4
        End If

        If k5.Text.Trim.Length <> Nothing Then
            My.Settings.k5 = k5.Text.Replace(" ", "")
            k5.Text = My.Settings.k5
        Else
            k5.Text = My.Settings.k5
        End If

        If k6.Text.Trim.Length <> Nothing Then
            My.Settings.k6 = k6.Text.Replace(" ", "")
            k6.Text = My.Settings.k6
        Else
            k6.Text = My.Settings.k6
        End If

        If k7.Text.Trim.Length <> Nothing Then
            My.Settings.k7 = k7.Text.Replace(" ", "")
            k7.Text = My.Settings.k7
        Else
            k7.Text = My.Settings.k7
        End If

        'Milk Shake

        If m1.Text.Trim.Length <> Nothing Then
            My.Settings.m1 = m1.Text.Replace(" ", "")
            m1.Text = My.Settings.m1
        Else
            m1.Text = My.Settings.m1
        End If

        If m2.Text.Trim.Length <> Nothing Then
            My.Settings.m2 = m2.Text.Replace(" ", "")
            m2.Text = My.Settings.m2
        Else
            m2.Text = My.Settings.m2
        End If

        If m3.Text.Trim.Length <> Nothing Then
            My.Settings.m3 = m3.Text.Replace(" ", "")
            m3.Text = My.Settings.m3
        Else
            m3.Text = My.Settings.m3
        End If

        If m4.Text.Trim.Length <> Nothing Then
            My.Settings.m4 = m4.Text.Replace(" ", "")
            m4.Text = My.Settings.m4
        Else
            m4.Text = My.Settings.m4
        End If

        If m5.Text.Trim.Length <> Nothing Then
            My.Settings.m5 = m5.Text.Replace(" ", "")
            m5.Text = My.Settings.m5
        Else
            m5.Text = My.Settings.m5
        End If

        If m6.Text.Trim.Length <> Nothing Then
            My.Settings.m6 = m6.Text.Replace(" ", "")
            m6.Text = My.Settings.m6
        Else
            m6.Text = My.Settings.m6
        End If

        'Lemonade

        If n1.Text.Trim.Length <> Nothing Then
            My.Settings.n1 = n1.Text.Replace(" ", "")
            n1.Text = My.Settings.n1
        Else
            n1.Text = My.Settings.n1
        End If

        If n2.Text.Trim.Length <> Nothing Then
            My.Settings.n2 = n2.Text.Replace(" ", "")
            n2.Text = My.Settings.n2
        Else
            n2.Text = My.Settings.n2
        End If

        'Crusher

        If r1.Text.Trim.Length <> Nothing Then
            My.Settings.r1 = r1.Text.Replace(" ", "")
            r1.Text = My.Settings.r1
        Else
            r1.Text = My.Settings.r1
        End If

        If r2.Text.Trim.Length <> Nothing Then
            My.Settings.r2 = r2.Text.Replace(" ", "")
            r2.Text = My.Settings.r2
        Else
            r2.Text = My.Settings.r2
        End If

        If r3.Text.Trim.Length <> Nothing Then
            My.Settings.r3 = r3.Text.Replace(" ", "")
            r3.Text = My.Settings.r3
        Else
            r3.Text = My.Settings.r3
        End If

        If r4.Text.Trim.Length <> Nothing Then
            My.Settings.r4 = r4.Text.Replace(" ", "")
            r4.Text = My.Settings.r4
        Else
            r4.Text = My.Settings.r4
        End If

        If r5.Text.Trim.Length <> Nothing Then
            My.Settings.r5 = r5.Text.Replace(" ", "")
            r5.Text = My.Settings.r5
        Else
            r5.Text = My.Settings.r5
        End If

        'Premium Chilled Coffee

        If p1.Text.Trim.Length <> Nothing Then
            My.Settings.p1 = p1.Text.Replace(" ", "")
            p1.Text = My.Settings.p1
        Else
            p1.Text = My.Settings.p1
        End If

        If p2.Text.Trim.Length <> Nothing Then
            My.Settings.p2 = p2.Text.Replace(" ", "")
            p2.Text = My.Settings.p2
        Else
            p2.Text = My.Settings.p2
        End If

        If p3.Text.Trim.Length <> Nothing Then
            My.Settings.p3 = p3.Text.Replace(" ", "")
            p3.Text = My.Settings.p3
        Else
            p3.Text = My.Settings.p3
        End If

        If p4.Text.Trim.Length <> Nothing Then
            My.Settings.p4 = p4.Text.Replace(" ", "")
            p4.Text = My.Settings.p4
        Else
            p4.Text = My.Settings.p4
        End If

        'Iced Tea

        If t1.Text.Trim.Length <> Nothing Then
            My.Settings.t1 = t1.Text.Replace(" ", "")
            t1.Text = My.Settings.t1
        Else
            t1.Text = My.Settings.t1
        End If

        If t2.Text.Trim.Length <> Nothing Then
            My.Settings.t2 = t2.Text.Replace(" ", "")
            t2.Text = My.Settings.t2
        Else
            t2.Text = My.Settings.t2
        End If

        If t3.Text.Trim.Length <> Nothing Then
            My.Settings.t3 = t3.Text.Replace(" ", "")
            t3.Text = My.Settings.t3
        Else
            t3.Text = My.Settings.t3
        End If



        My.Settings.Save()
    End Sub
End Class