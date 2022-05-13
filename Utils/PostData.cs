using NetCore_01.Models;

namespace NetCore_01.Utils
{
    public static class PostData
    {

        private static List<Post> posts;

        public static List<Post> GetPosts()
        {
            if(PostData.posts != null)
            {
                return PostData.posts;
            }

            List<Post> nuovaListaPosts = new List<Post>();

            for(int i=0; i<2; i++)
            {
                Post post = new Post(i, "Nome Pizza: " + i, " Descrizione della pizza.","Immagine" + i + "/800/500");
                nuovaListaPosts.Add(post);
            }

            PostData.posts = nuovaListaPosts;

            return PostData.posts;

        }

    }
}
