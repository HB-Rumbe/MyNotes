Book book = new Book("Programmerings bog");


List<Chapter> chapters = new List<Chapter>();

Chapter chapter1 = new Chapter("Chapter1");
Chapter chapter2 = new Chapter("Chapter2");

chapters.Add(chapter1);
chapters.Add(chapter2);




Page variabler1 = new Page(MyNotes.VariablesPageOne);
Page variabler2 = new Page(MyNotes.VariablesPageTwo);

Page Strings1 = new Page(MyNotes.Stringspageone);
Page Strings2 = new Page(MyNotes.Stringspagetwo);

List<Page> chapter1pages = new List<Page>(){
    variabler1,
    variabler2
};
List<Page> chapter2pages = new List<Page>(){
    Strings1,
    Strings2
};

chapter1.Pages = chapter1pages;

chapter2.Pages = chapter2pages;

book.Chapters = chapters;

book.Start();
