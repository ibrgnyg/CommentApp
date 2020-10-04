#pragma checksum "C:\Users\ibr günay\source\repos\CommentApp\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee0ef341b58639ef2febbcd2ad3d3933689bb4c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ibr günay\source\repos\CommentApp\Views\_ViewImports.cshtml"
using CommentApp;

#line default
#line hidden
#line 2 "C:\Users\ibr günay\source\repos\CommentApp\Views\_ViewImports.cshtml"
using CommentApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee0ef341b58639ef2febbcd2ad3d3933689bb4c3", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fb2aaa982b9a941ea44990363f028bcbc8e3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\ibr günay\source\repos\CommentApp\Views\Post\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(40, 10147, true);
            WriteLiteral(@"
<div class=""container"" id=""commentapp"">
	<main>
		<div class=""container"">
			<div class=""col-lg-7"">

				<div class=""card social-timeline-card"">
					<div class=""card-header"">
						just think...
					</div>

					<div class=""card-body"">
						<div class=""tab-content"" id=""myTabContent"">
							<div class=""tab-pane fade active show"" id=""posts"" role=""tabpanel"" aria-labelledby=""posts-tab"">
								<div class=""form-group"">
									<label class=""sr-only"" for=""message"">post</label>
									<div v-if=""file.length > 0"">
										<div class=""imag"">
											<img class=""preview"" :src=""file"" height=""200"" width=""300"">
										</div>
										<div class=""hız"">
											<button type=""button"" v-on:click=""resetFile"" class=""btn btn-light"" style=""background:#3D3B3B!important;border-radius:25px;border-color:white!important""> <i class=""fas fa-times"" style=""color:orangered;font-size:15px""></i></button>
										</div>
									</div>
									<br />
									<textarea class=""form-control"" id=""");
            WriteLiteral(@"message"" rows=""3"" v-model=""name"" placeholder=""What are you thinking?""></textarea>
								</div>
							</div>
							<button type=""button"" class=""btn btn-info "" v-bind:disabled=""DisabledBtn"" v-on:click=""ShareBtn"">Share</button>
							<div class=""float-right"">
								<label>
									<i class=""fas fa-image"" style='font-size:30px;color:deepskyblue;'></i>
									<input type=""file"" id=""file"" ref=""file"" v-on:change=""fileUpload"" accept=""image/*"" />
								</label>
							</div>

						</div>
					</div>
				</div>

				<div class=""list-group-item"">
					<span>Filter ></span>
					<button class=""btn border-info"" v-on:click=""newList"">New</button>
					<button class=""btn border-info"" v-on:click=""oldList""   v-if=""Result.length > 15"">Old</button>
					<button class=""btn border-info"" v-on:click=""mediaList""   >Media</button>
					<button v-if=""show"" class=""btn border-info"" v-on:click=""List"">x</button>
					<div class=""form-inline mr-auto float-right"">
						<input class=""form-control"" type=""tex");
            WriteLiteral(@"t"" v-model=""src"" placeholder=""Search Posts?"" aria-label=""Search"" />
					</div>
				</div>
				<br />

				<div class=""card social-timeline-card"" v-for=""(Result,index) in filterSrc"" v-bind:key=""Result.id"">

					<div class=""card-header"">
						<div class=""d-flex justify-content-between align-items-center"">
							<div class=""d-flex justify-content-between align-items-center"">
								<div class=""mr-2"">
									<img class=""rounded-circle"" width=""45"" src=""https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTG3eLpTAMWO-mtILepXLwg68-IChyGcXJgog&usqp=CAU"" alt="""">
								</div>
								<div class=""ml-2"">
									<div class=""h5 m-0 text-blue""></div>
									<div class=""h7 text-muted"">unknown</div>
								</div>
							</div>
							<div>
								<div class=""dropdown"">
									<button class=""btn btn-link dropdown-toggle"" type=""button"" id=""gedf-drop11"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
										<i class=""fa fa-ellipsis-h"" style=""color:black""></i>
						");
            WriteLiteral(@"			</button>
									<div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""gedf-drop11"">
										<div class=""h6 dropdown-header"">Configuration</div>
										<a class=""dropdown-item"" v-on:click=""Delete(Result,index)"">Delete Post</a>
										<a class=""dropdown-item"" v-on:click=""Edit(Result,index)"">Edit Post</a>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""card-body"">
						<div class=""text-muted h7 mb-2 float-right""> {{Result.createdDate| moment}}</div>
						<br />
						<h4 class=""card-title""><a :href=""'/post/Details/' + Result.id"">{{ Result.name }}</a></h4>
						<div v-if=""Result.photo"">
							<a :href=""'/post/Details/' + Result.id"">
								<img :src=""'https://localhost:44304/img/'+Result.photo"" class=""img-fluid"" alt=""Responsive image"" />
							</a>
						</div>
			
					</div>

					<div class=""card-footer"">
						<a class=""card-link"" v-on:click=""detayComment(Result,index)""><i class=""fa fa-comment""></i>  <u>Comment</u></a>");
            WriteLiteral(@"

					</div>

				</div>

			</div>

		</div>

	</main>

	<!--Edit Modal-->
	<div class=""modal fade"" id=""Edit"" tabindex=""-1"" role=""dialog"">
		<div class=""modal-dialog"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"">Post Edit</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">
					<textarea v-model=""name"" class="" form-control""></textarea>
					<br />

					<button type=""submit"" class=""btn btn-info"" v-bind:disabled=""DisabledBtnUpdate"" v-on:click=""EditCon"">
						update
					</button>

				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>

				</div>
			</div>
		</div>
	</div>

	<!--Comment Modal-->
	<div class=""modal fade"" id=""DetailsModal"" tabindex=""-1"" role=""dialog"">
		<div class=""modal-dialog"" role=""");
            WriteLiteral(@"document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"">Post Details and Comments</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">
					<div>
						<span>{{TotalCmtCnt}}</span> <i class=""fa fa-comment""></i> Comment
					</div>
					<br />
					<div v-if=""!CommentList.length"">
						<div class=""text-center"">
							<h5><span>No Comment</span></h5>
						</div>
					</div>

					<div class=""be-comment"" v-for=""CommentList in CommentList"" :key=""CommentList.id"" v-else=""CommentList"">
						<div class=""be-img-comment"">
							<div class=""mr-2"">
								<img class=""rounded-circle"" width=""45"" src=""https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTG3eLpTAMWO-mtILepXLwg68-IChyGcXJgog&usqp=CAU"" alt="""">
							</div>
						</div>
						<div class=""be-comment-content"">
							<span class=""be-comment-name"">
	");
            WriteLiteral(@"							<a>unknown</a>
							</span>
							<span class=""be-comment-time"">
								{{CommentList.createDate | moment}}
							</span>
							<h5 class=""be-comment-text"" style=""background-color:lightcyan"">
								{{CommentList.commentDes}}
							</h5>

						</div>
					</div>

				
				</div>

				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
				</div>
			</div>
		</div>
	</div>
</div>

<script>

	new Vue({
		el: ""#commentapp"",
		data() {
			return {
				Result: [],
				name: """",
				edit: null,
				src: '',
				CommentDes: '',
				file: '',
				CommentList: [],
				show: false,
			};

		},
		computed: {
			filterSrc() {
				return this.Result.filter(post => {
					return post.name.match(this.src);

				});
			},
			TotalCmtCnt() {
				return this.CommentList.reduce((tot, item) => {
					return tot + item.commentCount
				},0)
			},
			DisabledBtn() {
				var Disabled = true;

				if (t");
            WriteLiteral(@"his.name == """") {
					Disabled = true;
				}
				else {
					Disabled = false;
				}
				return Disabled;
			},
			DisabledBtnUpdate() {
				let Disabled = true;
				if (this.name == """") {
					Disabled = true;
				}
				else {
					Disabled = false;
				}
				return Disabled;
			},
			
		},

		methods: {

			

			Edit: function (data, index) {
				this.name = data.name;
				this.id = data.id;
				edit = index;

				$(""#Edit"").modal(""show"")
			},

			EditCon: function () {
				var vm = this;
				let formData = new FormData();
				formData.append('name', this.name);
				formData.append('id', this.id);
				axios.post('/post/update', formData)
					.then(function () {
						vm.Result[edit].name = vm.name;
						this.name = """";
					})

				$(""#Edit"").modal(""hide"");
			},

			//Delete post
			Delete: function (data) {
				var vm = this;
				var conDelete = confirm(""Are you sure to delete this?"");
				if (conDelete) {
					axios.delete(""/post/delete/"" + data.id)");
            WriteLiteral(@"
						.then(function (response) {
							alert(""Delete succesfuly""),
								vm.List(response);
						});
				}
			},

			fileUpload() {
				var input = event.target;
				if (input.files && input.files[0]) {

					var reader = new FileReader();
					reader.onload = (e) => {
						this.file = e.target.result;
					}
					reader.readAsDataURL(input.files[0]);
				}
			},
			//Create post
			ShareBtn: function () {
				this.file = this.$refs.file.files[0];
				var vm = this;
				let formData = new FormData();
				formData.append('file', this.file);
				formData.append(""name"", this.name);
				axios.post('/post/create', formData)
					.then(function (data) {
						vm.List(data);
					})
				this.name = """";
				this.file = """";
			},

			resetFile: function () {
				this.file = """";
			},

			List: function () {
				var vm = this;
				axios.get('/post/list')
					.then(function (response) {
						vm.Result = response.data;
					})
				this.show = false;

			},

			medi");
            WriteLiteral(@"aList() {
				var vm = this;
				this.show = true;
				axios.get(""/post/media"")
					.then(function (res) {
						vm.Result = res.data;
					})
			},

			oldList() {
				var vm = this;
				this.show = true;
				axios.get(""/post/oldlist"")
					.then(function (response) {
						vm.Result = response.data;
					})

			},
			newList() {
				var vm = this;
				this.show = true;
				axios.get(""/post/newlist"")
					.then(function (response) {
						vm.Result = response.data;
					})

			},

			detayComment: function (data) {
				var vm = this;
				axios.get(""/post/commentlist/"" + data.id)
					.then(function (response) {
						vm.CommentList = response.data;
						$(""#DetailsModal"").modal(""show"");
					});

			},

		},

		mounted() {
			this.List();
		},

		filters: {
			moment: function (date) {
				return moment(date).format('L');
			}

		},




	});

</script>



");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
