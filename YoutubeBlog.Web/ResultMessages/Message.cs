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
        }
    }
}
