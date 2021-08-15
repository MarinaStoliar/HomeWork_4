using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ServicesArticles
{
    public class ProcessPublischingArticle : IProcessPublischingArticle
    {

        private readonly IAddContentInArticle _addContentInArticle;
        private readonly ICheckArticleOnErrors _checkArticleOnErrors;
        private readonly IPublishArticle _publishArticle;
        IProcessPublischingArticle _processPublischingArticle;

        public ProcessPublischingArticle(IProcessPublischingArticle processPublischingArticle)
        {
            _processPublischingArticle = processPublischingArticle;
        }

        public ProcessPublischingArticle (
            IAddContentInArticle addContentInArticle,
            ICheckArticleOnErrors checkArticleOnErrors,
            IPublishArticle publishArticle
            )
        {
            _addContentInArticle = addContentInArticle;
            _checkArticleOnErrors = checkArticleOnErrors;
            _publishArticle = publishArticle;
        }

        
        void IProcessPublischingArticle.processPublischingArticle()
        {
            _addContentInArticle.AddContentInArticle();
            _checkArticleOnErrors.CheckArticleOnErrors();
            _publishArticle.PublishArticle();
            _processPublischingArticle.processPublischingArticle();
        }
        public void processPublischingArticle()
        {
            _processPublischingArticle.processPublischingArticle();
        }


    }
}
