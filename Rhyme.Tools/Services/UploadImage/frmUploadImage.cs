using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Aliyun.OpenServices.OpenStorageService;

namespace Rhyme.Tools.Services.UploadImage
{
	public partial class frmUploadImage : Form
	{
		private const string EndPoint = "http://oss-cn-hangzhou.aliyuncs.com";
		private const string AccessKeyId = "eavI6hjYgguCQLZb";
		private const string AccessKeySecret = "sa4RAULlbYvY6h4RkRZtrDI3Nl6KlV";
		private const string BucketName = "cdn-stage";

		public frmUploadImage()
		{
			InitializeComponent();
		}

		private void frmUploadImage_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
			dlg.Multiselect = true;
			dlg.ShowDialog();

			if (dlg.FileName.Length <= 0)
				return;
			
			var oss = new OssClient(EndPoint, AccessKeyId, AccessKeySecret);

			foreach (var fileName in dlg.FileNames)
			{
				using (var file = new FileStream(fileName, FileMode.Open))
				{
					var meta = new ObjectMetadata();
					meta.ContentLength = file.Length;

					var destName = "avatar/" + Path.GetFileName(fileName);

					var result = oss.PutObject(BucketName, destName, file, meta);
					textBox1.AppendText(string.Format("Uploaded : {0}, {1}\n", destName, result.ETag));
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var oss = new OssClient(EndPoint, AccessKeyId, AccessKeySecret);

			var images = oss.ListObjects(BucketName, "avatar");

			foreach (var image in images.ObjectSummaries)
			{
				if(image.Size > 0)
					textBox1.AppendText(string.Format("{0}, Size = {1} kb\n", image.Key, image.Size / 1000));
			}
		}
	}
}
