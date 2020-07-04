using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News_Technology_Web_Site.Array
{
    public class TableGS
    {
        public List<TableData> GmailShortcut()
        {
            List<TableData> gs = new List<TableData>();
            gs.Add(new TableData() { Title = "G سپس A", Der = "رفتن به بخش تمام ایمیل‌ها" });
            gs.Add(new TableData() { Title = "G سپس C", Der = "رفتن به بخش مخاطبان" });
            gs.Add(new TableData() { Title = "G سپس D", Der = "رفتن به بخش پیش ‌نویس‌ها" });
            gs.Add(new TableData() { Title = "G سپس I", Der = "رفتن به Inbox" });
            gs.Add(new TableData() { Title = "G سپس I", Der = "رفتن به Inbox" });
            gs.Add(new TableData() { Title = "G سپس K", Der = "رفتن به Tasks" });
            gs.Add(new TableData() { Title = "G سپس S", Der = "رفتن به بخش گفت‌وگوهای ستاره‌دار" });
            gs.Add(new TableData() { Title = "G سپس S", Der = "رفتن به بخش گفت‌وگوهای ستاره‌دار" });
            gs.Add(new TableData() { Title = "G سپس T", Der = "رفتن به بخش پیام‌های ارسالی" });
            gs.Add(new TableData() { Title = "G سپس T", Der = "رفتن به بخش پیام‌های ارسالی" });
            gs.Add(new TableData() { Title = "G سپس B", Der = "رفتن به بخش پیام‌های زمان‌بندی‌شده" });
            gs.Add(new TableData() { Title = "G سپس L", Der = "رفتن به بخش Label..." });
            gs.Add(new TableData() { Title = "X", Der = "انتخاب گفت‌وگو" });
            gs.Add(new TableData() { Title = "R", Der = "پاسخ‌دادن" });
            gs.Add(new TableData() { Title = "A", Der = "پاسخ‌دادن به همه" });
            gs.Add(new TableData() { Title = "E", Der = "آرشیوکردن" });
            gs.Add(new TableData() { Title = "F", Der = "Forward" });
            gs.Add(new TableData() { Title = "M", Der = "بی‌صداکردن گفت‌وگو" });
            gs.Add(new TableData() { Title = "N", Der = "بازکردن پیام بعدی در گفت‌وگو" });
            gs.Add(new TableData() { Title = "P", Der = "بازگشتن به پیام قبلی در گفت‌وگو" });
            gs.Add(new TableData() { Title = "S", Der = "ستاره‌دارکردن" });
            gs.Add(new TableData() { Title = "Z", Der = "بازگشتن از آخرین فرمان (Undo)" });
            gs.Add(new TableData() { Title = "!", Der = "گزارش اسپم ایمیل" });
            gs.Add(new TableData() { Title = "#", Der = "حذف ایمیل" });
            gs.Add(new TableData() { Title = ", (کاما)", Der = "انتخاب منو Toolbar" });
            gs.Add(new TableData() { Title = "- (منفی)", Der = "نشان Not Important زدن روی ایمیل" });
            gs.Add(new TableData() { Title = "= (مساوی)", Der = "نشان Important زدن روی ایمیل" });
            gs.Add(new TableData() { Title = "; (نقطه‌ویرگول)", Der = "بسط‌دادن تمام پیام‌های گفت‌وگو" });
            gs.Add(new TableData() { Title = ": (دونقطه)", Der = "بستن تمام پیام‌های گفت‌وگو" });
            gs.Add(new TableData() { Title = "]", Der = "آرشیو گفت‌وگو و رفتن به پیام قبلی" });
            gs.Add(new TableData() { Title = "[", Der = "آرشیو گفت‌وگو و رفتن به پیام بعدی" });
            gs.Add(new TableData() { Title = "Shift + A", Der = "پاسخ به همه در پنجره‌ی جدید" });
            gs.Add(new TableData() { Title = "Shift + F", Der = "ارسال (Forward) به همه در پنجره‌ی جدید" });
            gs.Add(new TableData() { Title = "Shift + I", Der = "علامت‌گذاری به‌عنوان خوانده‌شده" });
            gs.Add(new TableData() { Title = "Shift + U", Der = "علامت‌گذاری به‌عنوان خوانده‌نشده" });
            gs.Add(new TableData() { Title = "Shift + N", Der = "به‌روزرسانی گفت‌وگو" });
            gs.Add(new TableData() { Title = "Shift + R", Der = "پاسخ به ایمیل در پنجره‌ی جدید" });
            gs.Add(new TableData() { Title = "Shift + T", Der = "اضافه‌کردن گفت‌وگو به Tasks" });
            gs.Add(new TableData() { Title = "C", Der = "نوشتن پیام" });
            gs.Add(new TableData() { Title = "Ctrl + K", Der = "افزودن لینک" });
            gs.Add(new TableData() { Title = "Ctrl + M", Der = "بازکردن پیشنهادهای املایی" });
            gs.Add(new TableData() { Title = "Ctrl + Enter", Der = "ارسال پیام" });
            gs.Add(new TableData() { Title = "Shift + Ctrl + B", Der = "افزودن دریافت‌کنندگان BCC" });
            gs.Add(new TableData() { Title = "Shift + Ctrl + C", Der = "افزودن دریافت‌کنندگان CC" });
            gs.Add(new TableData() { Title = "Ctrl + B", Der = "بولد‌کردن فونت" });
            gs.Add(new TableData() { Title = "Ctrl + I", Der = "ایتالیک‌کردن فونت" });
            gs.Add(new TableData() { Title = "Ctrl + U", Der = "آندرلاین‌کردن" });
            gs.Add(new TableData() { Title = "] + Ctrl", Der = "کم‌کردن ایندنت" });
            gs.Add(new TableData() { Title = "[ + Ctrl", Der = "بیشترکردن ایندنت" });
            gs.Add(new TableData() { Title = "/ + Ctrl", Der = "حذف قالب‌بندی" });
            gs.Add(new TableData() { Title = "Shift + Ctrl + 7", Der = "فهرست شماره‌گذاری‌شده" });
            gs.Add(new TableData() { Title = "Shift + Ctrl + 8", Der = "فهرست نشانه‌گذاری‌شده با گلوله" });
            gs.Add(new TableData() { Title = "Shift + Ctrl + 9", Der = "نقل قول" });
            gs.Add(new TableData() { Title = "Shift + Ctrl + E", Der = "وسط‌ چین متن" });
            gs.Add(new TableData() { Title = "Shift + Ctrl + L", Der = "چپ‌ چین متن" });
            gs.Add(new TableData() { Title = "Shift + Ctrl + R", Der = "راست‌چین متن" });
            return gs;
        }
    }
}