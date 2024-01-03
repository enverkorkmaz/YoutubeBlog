namespace YoutubeBlog.Web.ResultMessages
{
    public static class Messages
    {
        public static class Article
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla eklenmiştir";
            }
            public static string Update(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla güncellendi.";
            }
            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silindi.";
            }
            public static string UndoDelete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla geri alındı.";
            }
        }
        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla eklenmiştir";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla güncellendi.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla silindi.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla geri alındı.";
            }
        }
        public static class User
        {
            public static string Add(string userName)
            {
                return $"{userName} mail adresli kullanıcı başarıyla eklenmiştir";
            }
            public static string Update(string userName)
            {
                return $"{userName} mail adresli kullanıcı başarıyla güncellendi.";
            }
            public static string Delete(string userName)
            {
                return $"{userName} mail adresli kullanıcı başarıyla silindi.";
            }
        }
    }
}
