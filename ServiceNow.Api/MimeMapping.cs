﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ServiceNow.Api
{
	public static class MimeMapping
	{
		private static Dictionary<string, string> _mappingDictionary;

		static MimeMapping()
		{
			Init();
		}

		public static string GetMimeMapping(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}

			string extension = Path.GetExtension(fileName);
			return _mappingDictionary[extension];
		}

		
		private static void Init()
		{
			// This list was copied from the IIS7 configuration file located at:
			// %windir%\system32\inetsrv\config\applicationHost.config
			_mappingDictionary = new Dictionary<string, string>();
			_mappingDictionary.Add(".323", "text/h323");
			_mappingDictionary.Add(".aaf", "application/octet-stream");
			_mappingDictionary.Add(".aca", "application/octet-stream");
			_mappingDictionary.Add(".accdb", "application/msaccess");
			_mappingDictionary.Add(".accde", "application/msaccess");
			_mappingDictionary.Add(".accdt", "application/msaccess");
			_mappingDictionary.Add(".acx", "application/internet-property-stream");
			_mappingDictionary.Add(".afm", "application/octet-stream");
			_mappingDictionary.Add(".ai", "application/postscript");
			_mappingDictionary.Add(".aif", "audio/x-aiff");
			_mappingDictionary.Add(".aifc", "audio/aiff");
			_mappingDictionary.Add(".aiff", "audio/aiff");
			_mappingDictionary.Add(".application", "application/x-ms-application");
			_mappingDictionary.Add(".art", "image/x-jg");
			_mappingDictionary.Add(".asd", "application/octet-stream");
			_mappingDictionary.Add(".asf", "video/x-ms-asf");
			_mappingDictionary.Add(".asi", "application/octet-stream");
			_mappingDictionary.Add(".asm", "text/plain");
			_mappingDictionary.Add(".asr", "video/x-ms-asf");
			_mappingDictionary.Add(".asx", "video/x-ms-asf");
			_mappingDictionary.Add(".atom", "application/atom+xml");
			_mappingDictionary.Add(".au", "audio/basic");
			_mappingDictionary.Add(".avi", "video/x-msvideo");
			_mappingDictionary.Add(".axs", "application/olescript");
			_mappingDictionary.Add(".bas", "text/plain");
			_mappingDictionary.Add(".bcpio", "application/x-bcpio");
			_mappingDictionary.Add(".bin", "application/octet-stream");
			_mappingDictionary.Add(".bmp", "image/bmp");
			_mappingDictionary.Add(".c", "text/plain");
			_mappingDictionary.Add(".cab", "application/octet-stream");
			_mappingDictionary.Add(".calx", "application/vnd.ms-office.calx");
			_mappingDictionary.Add(".cat", "application/vnd.ms-pki.seccat");
			_mappingDictionary.Add(".cdf", "application/x-cdf");
			_mappingDictionary.Add(".chm", "application/octet-stream");
			_mappingDictionary.Add(".class", "application/x-java-applet");
			_mappingDictionary.Add(".clp", "application/x-msclip");
			_mappingDictionary.Add(".cmx", "image/x-cmx");
			_mappingDictionary.Add(".cnf", "text/plain");
			_mappingDictionary.Add(".cod", "image/cis-cod");
			_mappingDictionary.Add(".cpio", "application/x-cpio");
			_mappingDictionary.Add(".cpp", "text/plain");
			_mappingDictionary.Add(".crd", "application/x-mscardfile");
			_mappingDictionary.Add(".crl", "application/pkix-crl");
			_mappingDictionary.Add(".crt", "application/x-x509-ca-cert");
			_mappingDictionary.Add(".csh", "application/x-csh");
			_mappingDictionary.Add(".css", "text/css");
			_mappingDictionary.Add(".csv", "application/octet-stream");
			_mappingDictionary.Add(".cur", "application/octet-stream");
			_mappingDictionary.Add(".dcr", "application/x-director");
			_mappingDictionary.Add(".deploy", "application/octet-stream");
			_mappingDictionary.Add(".der", "application/x-x509-ca-cert");
			_mappingDictionary.Add(".dib", "image/bmp");
			_mappingDictionary.Add(".dir", "application/x-director");
			_mappingDictionary.Add(".disco", "text/xml");
			_mappingDictionary.Add(".dll", "application/x-msdownload");
			_mappingDictionary.Add(".dll.config", "text/xml");
			_mappingDictionary.Add(".dlm", "text/dlm");
			_mappingDictionary.Add(".doc", "application/msword");
			_mappingDictionary.Add(".docm", "application/vnd.ms-word.document.macroEnabled.12");
			_mappingDictionary.Add(".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
			_mappingDictionary.Add(".dot", "application/msword");
			_mappingDictionary.Add(".dotm", "application/vnd.ms-word.template.macroEnabled.12");
			_mappingDictionary.Add(".dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template");
			_mappingDictionary.Add(".dsp", "application/octet-stream");
			_mappingDictionary.Add(".dtd", "text/xml");
			_mappingDictionary.Add(".dvi", "application/x-dvi");
			_mappingDictionary.Add(".dwf", "drawing/x-dwf");
			_mappingDictionary.Add(".dwp", "application/octet-stream");
			_mappingDictionary.Add(".dxr", "application/x-director");
			_mappingDictionary.Add(".eml", "message/rfc822");
			_mappingDictionary.Add(".emz", "application/octet-stream");
			_mappingDictionary.Add(".eot", "application/octet-stream");
			_mappingDictionary.Add(".eps", "application/postscript");
			_mappingDictionary.Add(".etx", "text/x-setext");
			_mappingDictionary.Add(".evy", "application/envoy");
			_mappingDictionary.Add(".exe", "application/octet-stream");
			_mappingDictionary.Add(".exe.config", "text/xml");
			_mappingDictionary.Add(".fdf", "application/vnd.fdf");
			_mappingDictionary.Add(".fif", "application/fractals");
			_mappingDictionary.Add(".fla", "application/octet-stream");
			_mappingDictionary.Add(".flr", "x-world/x-vrml");
			_mappingDictionary.Add(".flv", "video/x-flv");
			_mappingDictionary.Add(".gif", "image/gif");
			_mappingDictionary.Add(".gtar", "application/x-gtar");
			_mappingDictionary.Add(".gz", "application/x-gzip");
			_mappingDictionary.Add(".h", "text/plain");
			_mappingDictionary.Add(".hdf", "application/x-hdf");
			_mappingDictionary.Add(".hdml", "text/x-hdml");
			_mappingDictionary.Add(".hhc", "application/x-oleobject");
			_mappingDictionary.Add(".hhk", "application/octet-stream");
			_mappingDictionary.Add(".hhp", "application/octet-stream");
			_mappingDictionary.Add(".hlp", "application/winhlp");
			_mappingDictionary.Add(".hqx", "application/mac-binhex40");
			_mappingDictionary.Add(".hta", "application/hta");
			_mappingDictionary.Add(".htc", "text/x-component");
			_mappingDictionary.Add(".htm", "text/html");
			_mappingDictionary.Add(".html", "text/html");
			_mappingDictionary.Add(".htt", "text/webviewhtml");
			_mappingDictionary.Add(".hxt", "text/html");
			_mappingDictionary.Add(".ico", "image/x-icon");
			_mappingDictionary.Add(".ics", "application/octet-stream");
			_mappingDictionary.Add(".ief", "image/ief");
			_mappingDictionary.Add(".iii", "application/x-iphone");
			_mappingDictionary.Add(".inf", "application/octet-stream");
			_mappingDictionary.Add(".ins", "application/x-internet-signup");
			_mappingDictionary.Add(".isp", "application/x-internet-signup");
			_mappingDictionary.Add(".IVF", "video/x-ivf");
			_mappingDictionary.Add(".jar", "application/java-archive");
			_mappingDictionary.Add(".java", "application/octet-stream");
			_mappingDictionary.Add(".jck", "application/liquidmotion");
			_mappingDictionary.Add(".jcz", "application/liquidmotion");
			_mappingDictionary.Add(".jfif", "image/pjpeg");
			_mappingDictionary.Add(".jpb", "application/octet-stream");
			_mappingDictionary.Add(".jpe", "image/jpeg");
			_mappingDictionary.Add(".jpeg", "image/jpeg");
			_mappingDictionary.Add(".jpg", "image/jpeg");
			_mappingDictionary.Add(".js", "application/x-javascript");
			_mappingDictionary.Add(".jsx", "text/jscript");
			_mappingDictionary.Add(".latex", "application/x-latex");
			_mappingDictionary.Add(".lit", "application/x-ms-reader");
			_mappingDictionary.Add(".lpk", "application/octet-stream");
			_mappingDictionary.Add(".lsf", "video/x-la-asf");
			_mappingDictionary.Add(".lsx", "video/x-la-asf");
			_mappingDictionary.Add(".lzh", "application/octet-stream");
			_mappingDictionary.Add(".m13", "application/x-msmediaview");
			_mappingDictionary.Add(".m14", "application/x-msmediaview");
			_mappingDictionary.Add(".m1v", "video/mpeg");
			_mappingDictionary.Add(".m3u", "audio/x-mpegurl");
			_mappingDictionary.Add(".man", "application/x-troff-man");
			_mappingDictionary.Add(".manifest", "application/x-ms-manifest");
			_mappingDictionary.Add(".map", "text/plain");
			_mappingDictionary.Add(".mdb", "application/x-msaccess");
			_mappingDictionary.Add(".mdp", "application/octet-stream");
			_mappingDictionary.Add(".me", "application/x-troff-me");
			_mappingDictionary.Add(".mht", "message/rfc822");
			_mappingDictionary.Add(".mhtml", "message/rfc822");
			_mappingDictionary.Add(".mid", "audio/mid");
			_mappingDictionary.Add(".midi", "audio/mid");
			_mappingDictionary.Add(".mix", "application/octet-stream");
			_mappingDictionary.Add(".mmf", "application/x-smaf");
			_mappingDictionary.Add(".mno", "text/xml");
			_mappingDictionary.Add(".mny", "application/x-msmoney");
			_mappingDictionary.Add(".mov", "video/quicktime");
			_mappingDictionary.Add(".movie", "video/x-sgi-movie");
			_mappingDictionary.Add(".mp2", "video/mpeg");
			_mappingDictionary.Add(".mp3", "audio/mpeg");
			_mappingDictionary.Add(".mpa", "video/mpeg");
			_mappingDictionary.Add(".mpe", "video/mpeg");
			_mappingDictionary.Add(".mpeg", "video/mpeg");
			_mappingDictionary.Add(".mpg", "video/mpeg");
			_mappingDictionary.Add(".mpp", "application/vnd.ms-project");
			_mappingDictionary.Add(".mpv2", "video/mpeg");
			_mappingDictionary.Add(".ms", "application/x-troff-ms");
			_mappingDictionary.Add(".msi", "application/octet-stream");
			_mappingDictionary.Add(".mso", "application/octet-stream");
			_mappingDictionary.Add(".mvb", "application/x-msmediaview");
			_mappingDictionary.Add(".mvc", "application/x-miva-compiled");
			_mappingDictionary.Add(".nc", "application/x-netcdf");
			_mappingDictionary.Add(".nsc", "video/x-ms-asf");
			_mappingDictionary.Add(".nws", "message/rfc822");
			_mappingDictionary.Add(".ocx", "application/octet-stream");
			_mappingDictionary.Add(".oda", "application/oda");
			_mappingDictionary.Add(".odc", "text/x-ms-odc");
			_mappingDictionary.Add(".ods", "application/oleobject");
			_mappingDictionary.Add(".one", "application/onenote");
			_mappingDictionary.Add(".onea", "application/onenote");
			_mappingDictionary.Add(".onetoc", "application/onenote");
			_mappingDictionary.Add(".onetoc2", "application/onenote");
			_mappingDictionary.Add(".onetmp", "application/onenote");
			_mappingDictionary.Add(".onepkg", "application/onenote");
			_mappingDictionary.Add(".osdx", "application/opensearchdescription+xml");
			_mappingDictionary.Add(".p10", "application/pkcs10");
			_mappingDictionary.Add(".p12", "application/x-pkcs12");
			_mappingDictionary.Add(".p7b", "application/x-pkcs7-certificates");
			_mappingDictionary.Add(".p7c", "application/pkcs7-mime");
			_mappingDictionary.Add(".p7m", "application/pkcs7-mime");
			_mappingDictionary.Add(".p7r", "application/x-pkcs7-certreqresp");
			_mappingDictionary.Add(".p7s", "application/pkcs7-signature");
			_mappingDictionary.Add(".pbm", "image/x-portable-bitmap");
			_mappingDictionary.Add(".pcx", "application/octet-stream");
			_mappingDictionary.Add(".pcz", "application/octet-stream");
			_mappingDictionary.Add(".pdf", "application/pdf");
			_mappingDictionary.Add(".pfb", "application/octet-stream");
			_mappingDictionary.Add(".pfm", "application/octet-stream");
			_mappingDictionary.Add(".pfx", "application/x-pkcs12");
			_mappingDictionary.Add(".pgm", "image/x-portable-graymap");
			_mappingDictionary.Add(".pko", "application/vnd.ms-pki.pko");
			_mappingDictionary.Add(".pma", "application/x-perfmon");
			_mappingDictionary.Add(".pmc", "application/x-perfmon");
			_mappingDictionary.Add(".pml", "application/x-perfmon");
			_mappingDictionary.Add(".pmr", "application/x-perfmon");
			_mappingDictionary.Add(".pmw", "application/x-perfmon");
			_mappingDictionary.Add(".png", "image/png");
			_mappingDictionary.Add(".pnm", "image/x-portable-anymap");
			_mappingDictionary.Add(".pnz", "image/png");
			_mappingDictionary.Add(".pot", "application/vnd.ms-powerpoint");
			_mappingDictionary.Add(".potm", "application/vnd.ms-powerpoint.template.macroEnabled.12");
			_mappingDictionary.Add(".potx", "application/vnd.openxmlformats-officedocument.presentationml.template");
			_mappingDictionary.Add(".ppam", "application/vnd.ms-powerpoint.addin.macroEnabled.12");
			_mappingDictionary.Add(".ppm", "image/x-portable-pixmap");
			_mappingDictionary.Add(".pps", "application/vnd.ms-powerpoint");
			_mappingDictionary.Add(".ppsm", "application/vnd.ms-powerpoint.slideshow.macroEnabled.12");
			_mappingDictionary.Add(".ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow");
			_mappingDictionary.Add(".ppt", "application/vnd.ms-powerpoint");
			_mappingDictionary.Add(".pptm", "application/vnd.ms-powerpoint.presentation.macroEnabled.12");
			_mappingDictionary.Add(".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation");
			_mappingDictionary.Add(".prf", "application/pics-rules");
			_mappingDictionary.Add(".prm", "application/octet-stream");
			_mappingDictionary.Add(".prx", "application/octet-stream");
			_mappingDictionary.Add(".ps", "application/postscript");
			_mappingDictionary.Add(".psd", "application/octet-stream");
			_mappingDictionary.Add(".psm", "application/octet-stream");
			_mappingDictionary.Add(".psp", "application/octet-stream");
			_mappingDictionary.Add(".pub", "application/x-mspublisher");
			_mappingDictionary.Add(".qt", "video/quicktime");
			_mappingDictionary.Add(".qtl", "application/x-quicktimeplayer");
			_mappingDictionary.Add(".qxd", "application/octet-stream");
			_mappingDictionary.Add(".ra", "audio/x-pn-realaudio");
			_mappingDictionary.Add(".ram", "audio/x-pn-realaudio");
			_mappingDictionary.Add(".rar", "application/octet-stream");
			_mappingDictionary.Add(".ras", "image/x-cmu-raster");
			_mappingDictionary.Add(".rf", "image/vnd.rn-realflash");
			_mappingDictionary.Add(".rgb", "image/x-rgb");
			_mappingDictionary.Add(".rm", "application/vnd.rn-realmedia");
			_mappingDictionary.Add(".rmi", "audio/mid");
			_mappingDictionary.Add(".roff", "application/x-troff");
			_mappingDictionary.Add(".rpm", "audio/x-pn-realaudio-plugin");
			_mappingDictionary.Add(".rtf", "application/rtf");
			_mappingDictionary.Add(".rtx", "text/richtext");
			_mappingDictionary.Add(".scd", "application/x-msschedule");
			_mappingDictionary.Add(".sct", "text/scriptlet");
			_mappingDictionary.Add(".sea", "application/octet-stream");
			_mappingDictionary.Add(".setpay", "application/set-payment-initiation");
			_mappingDictionary.Add(".setreg", "application/set-registration-initiation");
			_mappingDictionary.Add(".sgml", "text/sgml");
			_mappingDictionary.Add(".sh", "application/x-sh");
			_mappingDictionary.Add(".shar", "application/x-shar");
			_mappingDictionary.Add(".sit", "application/x-stuffit");
			_mappingDictionary.Add(".sldm", "application/vnd.ms-powerpoint.slide.macroEnabled.12");
			_mappingDictionary.Add(".sldx", "application/vnd.openxmlformats-officedocument.presentationml.slide");
			_mappingDictionary.Add(".smd", "audio/x-smd");
			_mappingDictionary.Add(".smi", "application/octet-stream");
			_mappingDictionary.Add(".smx", "audio/x-smd");
			_mappingDictionary.Add(".smz", "audio/x-smd");
			_mappingDictionary.Add(".snd", "audio/basic");
			_mappingDictionary.Add(".snp", "application/octet-stream");
			_mappingDictionary.Add(".spc", "application/x-pkcs7-certificates");
			_mappingDictionary.Add(".spl", "application/futuresplash");
			_mappingDictionary.Add(".src", "application/x-wais-source");
			_mappingDictionary.Add(".ssm", "application/streamingmedia");
			_mappingDictionary.Add(".sst", "application/vnd.ms-pki.certstore");
			_mappingDictionary.Add(".stl", "application/vnd.ms-pki.stl");
			_mappingDictionary.Add(".sv4cpio", "application/x-sv4cpio");
			_mappingDictionary.Add(".sv4crc", "application/x-sv4crc");
			_mappingDictionary.Add(".swf", "application/x-shockwave-flash");
			_mappingDictionary.Add(".t", "application/x-troff");
			_mappingDictionary.Add(".tar", "application/x-tar");
			_mappingDictionary.Add(".tcl", "application/x-tcl");
			_mappingDictionary.Add(".tex", "application/x-tex");
			_mappingDictionary.Add(".texi", "application/x-texinfo");
			_mappingDictionary.Add(".texinfo", "application/x-texinfo");
			_mappingDictionary.Add(".tgz", "application/x-compressed");
			_mappingDictionary.Add(".thmx", "application/vnd.ms-officetheme");
			_mappingDictionary.Add(".thn", "application/octet-stream");
			_mappingDictionary.Add(".tif", "image/tiff");
			_mappingDictionary.Add(".tiff", "image/tiff");
			_mappingDictionary.Add(".toc", "application/octet-stream");
			_mappingDictionary.Add(".tr", "application/x-troff");
			_mappingDictionary.Add(".trm", "application/x-msterminal");
			_mappingDictionary.Add(".tsv", "text/tab-separated-values");
			_mappingDictionary.Add(".ttf", "application/octet-stream");
			_mappingDictionary.Add(".txt", "text/plain");
			_mappingDictionary.Add(".u32", "application/octet-stream");
			_mappingDictionary.Add(".uls", "text/iuls");
			_mappingDictionary.Add(".ustar", "application/x-ustar");
			_mappingDictionary.Add(".vbs", "text/vbscript");
			_mappingDictionary.Add(".vcf", "text/x-vcard");
			_mappingDictionary.Add(".vcs", "text/plain");
			_mappingDictionary.Add(".vdx", "application/vnd.ms-visio.viewer");
			_mappingDictionary.Add(".vml", "text/xml");
			_mappingDictionary.Add(".vsd", "application/vnd.visio");
			_mappingDictionary.Add(".vss", "application/vnd.visio");
			_mappingDictionary.Add(".vst", "application/vnd.visio");
			_mappingDictionary.Add(".vsto", "application/x-ms-vsto");
			_mappingDictionary.Add(".vsw", "application/vnd.visio");
			_mappingDictionary.Add(".vsx", "application/vnd.visio");
			_mappingDictionary.Add(".vtx", "application/vnd.visio");
			_mappingDictionary.Add(".wav", "audio/wav");
			_mappingDictionary.Add(".wax", "audio/x-ms-wax");
			_mappingDictionary.Add(".wbmp", "image/vnd.wap.wbmp");
			_mappingDictionary.Add(".wcm", "application/vnd.ms-works");
			_mappingDictionary.Add(".wdb", "application/vnd.ms-works");
			_mappingDictionary.Add(".wks", "application/vnd.ms-works");
			_mappingDictionary.Add(".wm", "video/x-ms-wm");
			_mappingDictionary.Add(".wma", "audio/x-ms-wma");
			_mappingDictionary.Add(".wmd", "application/x-ms-wmd");
			_mappingDictionary.Add(".wmf", "application/x-msmetafile");
			_mappingDictionary.Add(".wml", "text/vnd.wap.wml");
			_mappingDictionary.Add(".wmlc", "application/vnd.wap.wmlc");
			_mappingDictionary.Add(".wmls", "text/vnd.wap.wmlscript");
			_mappingDictionary.Add(".wmlsc", "application/vnd.wap.wmlscriptc");
			_mappingDictionary.Add(".wmp", "video/x-ms-wmp");
			_mappingDictionary.Add(".wmv", "video/x-ms-wmv");
			_mappingDictionary.Add(".wmx", "video/x-ms-wmx");
			_mappingDictionary.Add(".wmz", "application/x-ms-wmz");
			_mappingDictionary.Add(".wps", "application/vnd.ms-works");
			_mappingDictionary.Add(".wri", "application/x-mswrite");
			_mappingDictionary.Add(".wrl", "x-world/x-vrml");
			_mappingDictionary.Add(".wrz", "x-world/x-vrml");
			_mappingDictionary.Add(".wsdl", "text/xml");
			_mappingDictionary.Add(".wvx", "video/x-ms-wvx");
			_mappingDictionary.Add(".x", "application/directx");
			_mappingDictionary.Add(".xaf", "x-world/x-vrml");
			_mappingDictionary.Add(".xaml", "application/xaml+xml");
			_mappingDictionary.Add(".xap", "application/x-silverlight-app");
			_mappingDictionary.Add(".xbap", "application/x-ms-xbap");
			_mappingDictionary.Add(".xbm", "image/x-xbitmap");
			_mappingDictionary.Add(".xdr", "text/plain");
			_mappingDictionary.Add(".xla", "application/vnd.ms-excel");
			_mappingDictionary.Add(".xlam", "application/vnd.ms-excel.addin.macroEnabled.12");
			_mappingDictionary.Add(".xlc", "application/vnd.ms-excel");
			_mappingDictionary.Add(".xlm", "application/vnd.ms-excel");
			_mappingDictionary.Add(".xls", "application/vnd.ms-excel");
			_mappingDictionary.Add(".xlsb", "application/vnd.ms-excel.sheet.binary.macroEnabled.12");
			_mappingDictionary.Add(".xlsm", "application/vnd.ms-excel.sheet.macroEnabled.12");
			_mappingDictionary.Add(".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
			_mappingDictionary.Add(".xlt", "application/vnd.ms-excel");
			_mappingDictionary.Add(".xltm", "application/vnd.ms-excel.template.macroEnabled.12");
			_mappingDictionary.Add(".xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template");
			_mappingDictionary.Add(".xlw", "application/vnd.ms-excel");
			_mappingDictionary.Add(".xml", "text/xml");
			_mappingDictionary.Add(".xof", "x-world/x-vrml");
			_mappingDictionary.Add(".xpm", "image/x-xpixmap");
			_mappingDictionary.Add(".xps", "application/vnd.ms-xpsdocument");
			_mappingDictionary.Add(".xsd", "text/xml");
			_mappingDictionary.Add(".xsf", "text/xml");
			_mappingDictionary.Add(".xsl", "text/xml");
			_mappingDictionary.Add(".xslt", "text/xml");
			_mappingDictionary.Add(".xsn", "application/octet-stream");
			_mappingDictionary.Add(".xtp", "application/octet-stream");
			_mappingDictionary.Add(".xwd", "image/x-xwindowdump");
			_mappingDictionary.Add(".z", "application/x-compress");
			_mappingDictionary.Add(".zip", "application/x-zip-compressed");
		}
	}
}
