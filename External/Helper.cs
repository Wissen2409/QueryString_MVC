



public class Helper : IHelper
{

    public IHttpContextAccessor _context;
    public Helper(IHttpContextAccessor context)
    {
        _context = context;
    }
    public void GetQueryString()
    {
   

        //

         // HttpContext demek, web teknolojilerinde, ana sınıftır. Web'e ait bir çok şey httpcontext içerisinde yakalabilir

         // HttpContext'in içerisindekilere MVc Action içerisinden erişebilirsiniz

         // Ancak HttpContext'in içerisindekilere, action dışında bir sınıf içerisnde ulaşmak istediğinide, ulaşamazsınız

         // bu durumda, IHttpContextAccessor vasıtası ile iatediğiniz gibi erişebilirsiniz

         // Aşağıdaki örnekte, HTTPContext sınıfının içöerisindeki QueryString verisine, eriştik!!!..


        var queryString = _context.HttpContext.Request.QueryString;
    }
}
public interface IHelper
{
     public void GetQueryString();
}