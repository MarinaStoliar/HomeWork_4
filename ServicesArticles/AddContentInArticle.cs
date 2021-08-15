using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ServicesArticles
{
    public class AddContentInArticle : IAddContentInArticle
    {
        private readonly ISeveInformationAboutArticle _seveInformationAboutArticle;
        public AddContentInArticle(ISeveInformationAboutArticle seveInformationAboutArticle){
            _seveInformationAboutArticle = seveInformationAboutArticle;
        }
        void IAddContentInArticle.AddContentInArticle()
        {
            _seveInformationAboutArticle.SeveInformationAboutArticle();
        }
    }
}
