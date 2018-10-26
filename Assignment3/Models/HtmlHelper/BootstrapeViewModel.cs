using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Assigment3.HtmlHelpers
{
    public static class HtmlHelperExtensions
    {

        public static IHtmlString BootstrapModalWindow(this HtmlHelper helper)
        {
            var html = @"<button type='button' class='btn btn-info btn - lg' data-toggle='modal' data-target='#myModal'>Open Modal</button>
                          <div id = 'myModal' class='modal fade' role='dialog'>
                            <div class='modal-dialog'>
                                 <div class='modal-content'>
                                     <div class='modal-header'>
                                         <button type = 'button' class='close' data-dismiss='modal'>&times;</button>
                                             <h4 class='modal-title'>Modal Header</h4>
                                     </div>
                                     <div class='modal-body'>
                                        <p>Some text in the modal.</p>
                                     </div>
                                      <div class='modal-footer'>
                                        <button type = 'button' class='btn btn-default' data-dismiss='modal'>Close</button>
                                      </div>
                                  </div>
                              </div>
                            </div>";
            return MvcHtmlString.Create(html);
        }
    }
}