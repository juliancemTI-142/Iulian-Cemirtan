//---------------------------------------------------------------------------

#include <vcl.h>
#include <stdio.h>
#include <dos.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
struct date d;
struct time t;
unsigned int min = 0;
unsigned int sec = 0;
unsigned int zec = 0;

//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
        Edit2->Clear();
        Timer1->Enabled = true;
        Timer2->Enabled = false;
        Button1->Enabled = true;
        Button2->Enabled = false;
        Button3->Enabled = false;

        Button1->Hint = "Pornirea cronometrului";
        Button2->Hint = "Oprirea cronometrului";
        Button3->Hint = "Initializarea cronometrului";
        Button4->Hint = "Iesirea din program";

        Button1->ShowHint = true;
        Button2->ShowHint = false;
        Button3->ShowHint = false;
        Button4->ShowHint = true;

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

void __fastcall TForm1::Button4Click(TObject *Sender)
{
        Form1->Close();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
        Timer2->Enabled = true;

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer2Timer(TObject *Sender)
{
        Button1->Enabled = false;
        Button2->Enabled = true;
        Button3->Enabled = false;

        Button1->ShowHint = false;
        Button2->ShowHint = true;
        Button3->ShowHint = false;

        char buf[20];

        zec++;
        
        if(zec > 9)
        {
                zec = 0;
                sec++;
        }
        if(sec > 59)
        {
                sec = 0;
                min++;
        }

        sprintf(buf,"%02d min %02d sec %01d zec", min, sec, zec);
        Edit2->Text=(AnsiString)buf;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
        Timer2->Enabled = false;
        Button1->Enabled = false;
        Button2->Enabled = false;
        Button3->Enabled = true;

        Button1->ShowHint = false;
        Button2->ShowHint = false;
        Button3->ShowHint = true;
}
//---------------------------------------------------------------------------



void __fastcall TForm1::Button3Click(TObject *Sender)
{
        Button1->Enabled = true;
        Button2->Enabled = false;
        Button3->Enabled = false;

        Button1->ShowHint = true;
        Button2->ShowHint = false;
        Button3->ShowHint = false;

        min = 0;
        sec = 0;
        zec = 0;

        char buf[20];
        sprintf(buf,"%02d min %02d sec %01d zec", min, sec, zec);
        Edit2->Text=(AnsiString)buf;
}
//---------------------------------------------------------------------------

