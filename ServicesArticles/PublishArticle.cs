using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ServicesArticles
{
    public class PublishArticle : IPublishArticle
    {
        private readonly ISeveInformationAboutArticle _seveInformationAboutArticle;
        public PublishArticle(ISeveInformationAboutArticle seveInformationAboutArticle)
        {
            _seveInformationAboutArticle = seveInformationAboutArticle;
        }
        void IPublishArticle.PublishArticle()
        {
            _seveInformationAboutArticle.SeveInformationAboutArticle();
        }
    }
}
