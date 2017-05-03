using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using TheProject.core.Entity;
using TheProject.dal.IRepository;

namespace TheProject.mvc.webapi.Controllers
{

    //[Authorize]
    public class ValuesController : ApiController
    {
        private readonly ITreeRepository _menuRepo;
        private List<Tree> _treeData;
        private static XDocument _doc = new XDocument();

        public ValuesController()
        {

        }
        public ValuesController(ITreeRepository menuRepo)
        {
            _menuRepo = menuRepo;
          
        }
        // GET api/values
        public IHttpActionResult Get()
        {
            _treeData = new List<Tree>();
            _treeData = _menuRepo.GetAll().ToList();

            var res = GenerateTopicsTreeRcursively(_treeData);
            var formatResult = JsonConvert.SerializeObject(res);

            return Ok(formatResult);
        }
        public static XElement GenerateTopicsTreeRcursively(List<Tree> treeViewData)
        {
            try
            {
                XElement root = new XElement("root");

                foreach (var topic in treeViewData.Where(s => s.ParentId == 0))
                {
                    //root.Add(XElement.Parse($'<Id>{topic.ID}</Id>'));
                    //root.Add(XElement.Parse($'<Description>{topic.Description}</Description>'));
                    var children = new XElement("nodes",
                       new XElement("id", topic.ID),
                      new XElement("name", topic.Description));

                    var res = AddNodesRecursively(children, treeViewData, topic.ID);
                    root.Add(children);
                }
                return root;
            }
            catch
            {
                // would implement a custom error logger 
                throw;
            }
        }


        public static XElement AddNodesRecursively(XElement rootnode, List<Tree> treeViewData, int rootId)
        {
            try
            {
                var current = treeViewData.Where(o => o.ParentId == rootId);
                foreach (var item in current)
                {
                    var children = new XElement("children",
                         new XElement("id", item.ID),
                        new XElement("name", item.Description));
                    rootnode.Add(children);
                    AddNodesRecursively(children, treeViewData, item.ID);
                }

                return rootnode;
            }
            catch
            {
                throw;
            }

        }


        // GET api/values/5
        /// <summary>
        /// just for show, 
        /// </summary>
        /// <param name='id'></param>
        /// <returns></returns>
        public async Task<Tree> GetByParentID(int id)
        {
            return await _menuRepo.GetByParentIdAsync(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
