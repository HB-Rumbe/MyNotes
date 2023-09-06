Book book = new Book("Programmerings bog");


List<Chapter> chapters = new List<Chapter>();

Chapter chapter1 = new Chapter("Chapter1");
Chapter chapter2 = new Chapter("Chapter2");

chapters.Add(chapter1);
chapters.Add(chapter2);




Page variabler1 = new Page(MyNotes.VariablesPageOne);

List<Page> chapter1pages = new List<Page>(){
    variabler1
};

chapter1.Pages = chapter1pages;

book.Chapters = chapters;

book.Start();
