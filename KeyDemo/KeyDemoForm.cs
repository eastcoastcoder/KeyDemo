using System;
using System.Windows.Forms;

namespace KeyDemo
{
   
   public partial class KeyDemoForm : Form
   {
     
      public KeyDemoForm()
      {
         InitializeComponent();
      }

       // Handles KeyDown events, setting Button BackColor
      private void KeyDemoForm_KeyDown( object sender, KeyEventArgs e )
      {
          if (e.Shift)
          {
              LShiftKey.BackColor = System.Drawing.SystemColors.ActiveCaption;
              RShiftKey.BackColor = System.Drawing.SystemColors.ActiveCaption;
          }
          else if (e.Control)
          {
              LControlKey.BackColor = System.Drawing.SystemColors.ActiveCaption;
              RControlKey.BackColor = System.Drawing.SystemColors.ActiveCaption;
          }
          else if (e.Alt)
          {
              LAlt.BackColor = System.Drawing.SystemColors.ActiveCaption;
              RAlt.BackColor = System.Drawing.SystemColors.ActiveCaption;
          }
          else
              getKeypress(e).BackColor = System.Drawing.SystemColors.ActiveCaption;
      }

      private System.Windows.Forms.Button getKeypress(KeyEventArgs e)
      {

          switch (e.KeyCode)
          {
              // Row 1
              case Keys.Escape:
                  return Escape;
              case Keys.F1:
                  return F1;
              case Keys.F2:
                  return F2;
              case Keys.F3:
                  return F3;
              case Keys.F4:
                  return F4;
              case Keys.F5:
                  return F5;
              case Keys.F6:
                  return F6;
              case Keys.F7:
                  return F7;
              case Keys.F8:
                  return F8;
              case Keys.F9:
                  return F9;
              case Keys.F10:
                  return F10;
              case Keys.F11:
                  return F11;
              case Keys.F12:
                  return F12;

              // Row 2
              case Keys.Oemtilde:
                  return Oemtilde;
              case Keys.D1:
                  return D1;
              case Keys.D2:
                  return D2;
              case Keys.D3:
                  return D3;
              case Keys.D4:
                  return D4;
              case Keys.D5:
                  return D5;
              case Keys.D6:
                  return D6;
              case Keys.D7:
                  return D7;
              case Keys.D8:
                  return D8;
              case Keys.D9:
                  return D9;
              case Keys.D0:
                  return D0;
              case Keys.OemMinus:
                  return OemMinus;
              case Keys.Oemplus:
                  return Oemplus;
              case Keys.Back:
                  return Back;

              // Row 3
              case Keys.Tab:
                  return Tab;
              case Keys.Q:
                  return Q;
              case Keys.W:
                  return W;
              case Keys.E:
                  return E;
              case Keys.R:
                  return R;
              case Keys.T:
                  return T;
              case Keys.Y:
                  return Y;
              case Keys.U:
                  return U;
              case Keys.I:
                  return I;
              case Keys.O:
                  return O;
              case Keys.P:
                  return P;
              case Keys.OemOpenBrackets:
                  return OemOpenBrackets;
              case Keys.Oem6:
                  return Oem6;
              case Keys.Oem5:
                  return Oem5;

              // Row 4
              case Keys.Capital:
                  return Capital;
              case Keys.A:
                  return A;
              case Keys.S:
                  return S;
              case Keys.D:
                  return D;
              case Keys.F:
                  return F;
              case Keys.G:
                  return G;
              case Keys.H:
                  return H;
              case Keys.J:
                  return J;
              case Keys.K:
                  return K;
              case Keys.L:
                  return L;
              case Keys.Oem1:
                  return Oem1;
              case Keys.Oem7:
                  return Oem7;
              case Keys.Return:
                  return Return;
              
              // Row 5
              case Keys.Z:
                  return Z;
              case Keys.X:
                  return X;
              case Keys.C:
                  return C;
              case Keys.V:
                  return V;
              case Keys.B:
                  return B;
              case Keys.N:
                  return N;
              case Keys.M:
                  return M;
              case Keys.Oemcomma:
                  return Oemcomma;
              case Keys.OemPeriod:
                  return OemPeriod;
              case Keys.OemQuestion:
                  return OemQuestion;
                 
              // Row 5
              case Keys.Alt:
                  return LAlt;
              case Keys.LWin:
                  return LWin;
              case Keys.Space:
                  return Space;
              case Keys.RWin:
                  return RWin;
              case Keys.Apps:
                  return Apps;
          
          }
          
          return Escape;
      }

       // Handles KeyUp events, resetting Button BackColor
      private void KeyDemoForm_KeyUp( object sender, KeyEventArgs e )
      {
              getKeypress(e).UseVisualStyleBackColor = true;
              LShiftKey.UseVisualStyleBackColor = true;
              RShiftKey.UseVisualStyleBackColor = true;
              LControlKey.UseVisualStyleBackColor = true;
              RControlKey.UseVisualStyleBackColor = true;
              LAlt.UseVisualStyleBackColor = true;
              RAlt.UseVisualStyleBackColor = true;
      }

      private void KeyDemoForm_KeyPress(object sender, KeyPressEventArgs e)
      {
          outputBox.Text += e.KeyChar;

          if (e.KeyChar == 8)
          {
              outputBox.Text = "";
          }
      }

   }
} 