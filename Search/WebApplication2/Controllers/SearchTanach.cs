using dto;
using Microsoft.AspNetCore.Mvc;
using bll;


namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchTanachController : Controller
    {
        [HttpGet("getSearchResults/{word}")]
        public List<torah> getSearchResults(string word)
        {
            List<torah> l = bll.searchText.searchT(word);
            return l;
        }
        [HttpGet("getSearchRT/{word}")]
        public List<torah> getSearchRT(string word)
        {
            List<torah> rt = bll.searchRT.searchPasukByRT(word);
            return rt;
        }
        [HttpGet("getSearchGimatriya/{word}")]
        public List<torah> getSearchByGimatriya(string word)
        {
            List<torah> rt = bll.searchGimat.searchG(word);
            return rt;
        }


    }
        

    
}
