//---------------------------------------------------------------------------

#include <vcl.h>
#include <stdio.h>
#include <time.h>
#include <dos.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"

using namespace std;

TForm1 *Form1;
struct date d;
struct time t;
int y_prev = 132;
int y;

randomize(); // START ENGINE

//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{

        Timer1->Enabled = true;
        Timer2->Enabled = false;
        Timer2->Interval = 1;
        Button1->Enabled = true;
        Button2->Enabled = false;

        Timer2->Enabled = true; // PaintBoxMain Context Initialization
        Panel2->Height = 265;

        char buf[20];
        getdate(&d);
        gettime(&t);

        sprintf(buf,"   %02d-%02d-%4d  %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,
        t.ti_hour, t.ti_min, t.ti_sec);
        Edit1->Text=(AnsiString)buf;
        
}
//---------------------------------------------------------------------------




void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
        char buf[20];
        getdate(&d);
        gettime(&t);

        sprintf(buf,"   %02d-%02d-%4d  %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,
        t.ti_hour, t.ti_min, t.ti_sec);

        Edit1->Text=(AnsiString)buf;        
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
        Timer2->Enabled = true;
        Timer2->Interval = 500;
        Button1->Enabled = false;
        Button2->Enabled = true;
        Button1->ShowHint = false;
        Button2->ShowHint = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer2Timer(TObject *Sender)
{

        y = (int)(rand() % 101) - 50;

        PaintBoxMain->Canvas->Pen->Color = clBlack;
        PaintBoxMain->Canvas->Pen->Width = 1;
        PaintBoxMain->Canvas->Pen->Style = psSolid;
        PaintBoxMain->Canvas->Rectangle(0, 0, 256, 265);

        PaintBoxMain->Canvas->Pen->Color = clRed;
        PaintBoxMain->Canvas->Pen->Width = 3;
        PaintBoxMain->Canvas->Pen->Style = psDash;
        PaintBoxMain->Canvas->Brush->Color = clBlack;
        PaintBoxMain->Canvas->Brush->Style = bsCross;

        if(Button1->Enabled)
        {
                return;
        }

        TRect sursa, dest;
        sursa = Rect(4,0,235,265);
        dest = Rect(12,0,243,265);

        TRect Lrect, Rrect;
        Lrect = Rect(4,0,12,265);
        Rrect = Rect(244,0,251,265);

        PaintBoxMain->Canvas->MoveTo(12, y_prev);
        PaintBoxMain->Canvas->LineTo(5, 132 + y);
        y_prev = 132 + y;

        PaintBoxMain->Canvas->CopyRect(dest, PaintBoxMain->Canvas, sursa);
        PaintBoxMain->Canvas->CopyRect(Lrect, PaintBoxMain->Canvas, Rrect);

        Panel2->Height = 132 + y;

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
        Button1->Enabled = true;
        Button2->Enabled = false;
        Button1->ShowHint = true;
        Button2->ShowHint = false;

        PaintBoxMain->Repaint();
        Timer2->Interval = 1;
        Panel2->Height = 265;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender)
{
        Form1->Close();        
}
//---------------------------------------------------------------------------

