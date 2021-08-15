using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ServicesArticles
{
    public class CheckArticleOnErrors : ICheckArticleOnErrors
    {
        private readonly ISeveInformationAboutArticle _seveInformationAboutArticle;
        public CheckArticleOnErrors(ISeveInformationAboutArticle seveInformationAboutArticle)
        {
            _seveInformationAboutArticle = seveInformationAboutArticle;
        }

        void ICheckArticleOnErrors.CheckArticleOnErrors()
        {
            _seveInformationAboutArticle.SeveInformationAboutArticle();
        }
    }
}
