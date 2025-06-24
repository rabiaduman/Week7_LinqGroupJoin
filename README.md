Bir okul veritabanı oluşturuyorsunuz ve aşağıdaki iki tablonun verilerini kullanarak group join işlemi gerçekleştirmeniz gerekiyor:

Öğrenciler Tablosu (Students)

StudentId: Öğrencinin benzersiz kimliği

StudentName: Öğrencinin adı

ClassId: Öğrencinin ait olduğu sınıfın kimliği

Sınıflar Tablosu (Classes)

ClassId: Sınıfın benzersiz kimliği

ClassName: Sınıfın adı

LINQ Sorgusu:

Öğrenciler ve sınıflar arasında group join işlemi yaparak, her sınıfın altında o sınıfa ait olan öğrenciler listeleniyor.
