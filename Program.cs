Book book = new Book("Programmerings bog");


List<Chapter> chapters = new List<Chapter>();

Chapter chapter1 = new Chapter("Variabler");
Chapter chapter2 = new Chapter("Strings");
Chapter chapter3 = new Chapter("Loops and Arrays");
Chapter chapter4 = new Chapter("Methods");
Chapter chapter5 = new Chapter("OOP");
Chapter chapter6 = new Chapter("Fields");

chapters.Add(chapter1);
chapters.Add(chapter2);
chapters.Add(chapter3);
chapters.Add(chapter4);
chapters.Add(chapter5);
chapters.Add(chapter6);

Page variabler1 = new Page(MyNotes.VariablesPageOne);
Page variabler2 = new Page(MyNotes.VariablesPageTwo);

Page Strings1 = new Page(MyNotes.Stringspageone);
Page Strings2 = new Page(MyNotes.Stringspagetwo);

Page looparrays1 = new Page(MyNotes.Looparrays1);
Page Loopsarrays2 = new Page(MyNotes.Looparrays2);

Page methods1 = new Page(MyNotes.Methods1);
Page methods2 = new Page(MyNotes.Methods2);

Page OOP1 = new Page(MyNotes.OOP1);
Page OOP2 = new Page(MyNotes.OOP2);

Page fields1 = new Page(MyNotes.Fields1);
Page fields2 = new Page(MyNotes.Fields2);

List<Page> chapter1pages = new List<Page>(){
    variabler1,
    variabler2
};
List<Page> chapter5pages = new List<Page>(){
    Strings1,
    Strings2
};
List<Page> chapter2pages = new List<Page>(){
    looparrays1,
    Loopsarrays2
};
List<Page> chapter3pages = new List<Page>(){
    methods1,
    methods2
};
List<Page> chapter4pages = new List<Page>(){
    OOP1,
    OOP2
};
List<Page> chapter6pages = new List<Page>(){
    fields1,
    fields2
};

chapter1.Pages = chapter1pages;

chapter2.Pages = chapter2pages;

chapter3.Pages = chapter3pages;

chapter4.Pages = chapter4pages;

chapter5.Pages = chapter5pages;

chapter6.Pages = chapter6pages;

book.Chapters = chapters;

book.Start();



