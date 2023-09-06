Book book = new Book("Programmerings bog");


List<Chapter> chapters = new List<Chapter>();

Chapter chapter1 = new Chapter("Chapter1");
Chapter chapter2 = new Chapter("Chapter2");

chapters.Add(chapter1);
chapters.Add(chapter2);

Page.read();



Page variabler1 = new Page("variabler");

List<Page> Chapterpages = new List<Page>(){
    variabler1
};

Book.start();
