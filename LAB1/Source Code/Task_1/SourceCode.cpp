//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "SourceCode.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1    *Form1;
// int    i;

//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------



void __fastcall TForm1::Button3Click(TObject *Sender)
{
        Form1->Close();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
   //i = Edit1->Text.ToInt();
   //Edit1->Text = IntToStr( ++i );


   Edit1->Text = IntToStr( Edit1->Text.ToInt()+1 );
   Label2->Caption = "In Edit1 valoarea lui i creste";

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
   //i = Edit1->Text.ToInt();
   //Edit1->Text = IntToStr( --i );

   Edit1->Text = IntToStr( Edit1->Text.ToInt()-1 );
   Label2->Caption = "In Edit1 valoarea lui i scade";
}
//---------------------------------------------------------------------------



