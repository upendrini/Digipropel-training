using System;

namespace july7._7
{
    class july77
    {
        
            public class PhotoAlbum
{
 	protected int numberOfPages;

	public int GetNumberOfPages() {
		return numberOfPages;
	}
	public PhotoAlbum() {
		numberOfPages = 15;
	}
	public PhotoAlbum(int numberOfPages) {
		this.numberOfPages = numberOfPages;
	}
}



public class BigPhotoAlbum : PhotoAlbum {

	public BigPhotoAlbum(){
		numberOfPages = 60;
	}

}

public class AlbumTest {
	public static void Main() {

		PhotoAlbum p1 = new PhotoAlbum();
		Console.WriteLine("Photo1: "+p1.GetNumberOfPages());


		PhotoAlbum p2 = new PhotoAlbum(24);
		Console.WriteLine("Photo2: "+p2.GetNumberOfPages());

		BigPhotoAlbum p3 = new BigPhotoAlbum();
		Console.WriteLine("Photo3: "+p3.GetNumberOfPages());

}

}
        
    }
}
