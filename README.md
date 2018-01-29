# NugetSampleProject
Porting .Net Framework packages to .Net Core and using them via Nuget

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
<HEAD>	
</HEAD>
<BODY LANG="en-US" LINK="#0000ff" DIR="LTR">
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif"><B>Nuget
</B></FONT><FONT FACE="Cambria, serif">: is a free and open source
package manager designed for the Microsoft development platform.</FONT></P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif"><B>Steps
to port .Net framework project to .Net Core Nuget package</B></FONT></P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Before
we start creating Nuget packages for .net framework projects to
different platforms. Let’s first discuss why do we have to do
this??</FONT></P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">As we
all know .Net core is new web Framework, Microsoft has launched which
is platform independent. Which means .Net core apps developed can be
deployed and run on other platforms like MacOS, Linux, Windows etc. </FONT>
</P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">But In
our scenario, we are creating a new Project RAPI(Riskware API), which
will used as an API end-point to use our services. As we are building
this project in .Net core, we want our existing services to support
this project which .Net Framework centric. In order to achieve this
we need to convert our projects to .Net Standard or .Net Core, create
a Nuget package for this projects and use them in the projects that
requires these services.</FONT></P>
<OL>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Right
	click on the project and unload the Project.</FONT></P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">After
	unloading the project, Make following changes to the 
	&lt;Project&gt;.csproj file.</FONT></P>
</OL>
<P STYLE="margin-bottom: 0.11in; border: 1px solid #00000a; padding: 0.01in 0.06in">
<FONT FACE="Cambria, serif"><B>Change the below code</B></FONT></P>
<P STYLE="margin-bottom: 0.11in; border: 1px solid #00000a; padding: 0.01in 0.06in">
<FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">Project</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">
</FONT></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">ToolsVersion</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">=</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&quot;</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">4.0</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&quot;</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">
</FONT></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">DefaultTargets</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">=</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&quot;</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">Build</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&quot;</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">
</FONT></FONT></FONT><FONT COLOR="#ff0000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">xmlns</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">=</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&quot;</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">http://schemas.microsoft.com/developer/msbuild/2003</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&quot;</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;</FONT></FONT></FONT></P>
<P STYLE="margin-bottom: 0.11in; border: 1px solid #00000a; padding: 0.01in 0.06in">
<FONT FACE="Cambria, serif"><B>To this </B></FONT>
</P>
<P STYLE="margin-bottom: 0.11in; border: 1px solid #00000a; padding: 0.01in 0.06in"><A NAME="OLE_LINK2"></A><A NAME="OLE_LINK1"></A>
<FONT FACE="Cambria, serif">&lt;Project Sdk=&quot;Microsoft.NET.Sdk&quot;
ToolsVersion=&quot;15.0&quot;&gt;</FONT></P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><A NAME="_GoBack"></A><FONT FACE="Cambria, serif"><B>Add
this code on the csproj file</B></FONT></P>
<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT COLOR="#0000ff">
<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">PropertyGroup</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;
     </FONT></FONT></FONT>
</P>
<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT COLOR="#0000ff">
  
<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">TargetFrameworks</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">netstandard2.0;netcoreapp2.0;net461;</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;/</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">TargetFrameworks</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;
   </FONT></FONT></FONT>
</P>
<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT COLOR="#0000ff">
   <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">RuntimeIdentifiers</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">win7-x86;win7-x64</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;/</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">RuntimeIdentifiers</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;
                                                          </FONT></FONT></FONT>
</P>
<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT COLOR="#0000ff">
   <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">Title</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">Project
A Package</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;/</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">Title</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;
   </FONT></FONT></FONT>
</P>
<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT COLOR="#0000ff">
   <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">GeneratePackageOnBuild</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">True</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;/</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">GeneratePackageOnBuild</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;
   </FONT></FONT></FONT>
</P>
<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT COLOR="#0000ff">
   <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">Version</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">2.0.0</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;/</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">Version</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;
   </FONT></FONT></FONT>
</P>
<P STYLE="margin-bottom: 0in; line-height: 100%"><FONT COLOR="#0000ff">
   <FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">EnableDefaultCompileItems</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;</FONT></FONT></FONT><FONT COLOR="#000000"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">false</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;/</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">EnableDefaultCompileItems</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;
 </FONT></FONT></FONT>
</P>
<P STYLE="margin-bottom: 0.11in"><FONT COLOR="#0000ff"> 
<FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&lt;/</FONT></FONT></FONT><FONT COLOR="#a31515"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">PropertyGroup</FONT></FONT></FONT><FONT COLOR="#0000ff"><FONT FACE="Consolas, serif"><FONT SIZE=2 STYLE="font-size: 9pt">&gt;</FONT></FONT></FONT></P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<TABLE WIDTH=623 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=179>
	<COL WIDTH=415>
	<TR VALIGN=TOP>
		<TD WIDTH=179 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">PropertyGroup:</FONT></P>
		</TD>
		<TD WIDTH=415 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Contains a ser of user-defined
			property elements. Every property used in an MSBuild project must
			be a child of a PropertyGroup element.</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=179 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">TargetFrameworks:</FONT></P>
		</TD>
		<TD WIDTH=415 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">TargetFramework element specifies
			the API’s that you want to make your app available in.</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=179 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">RuntimeIdentifiers:</FONT></P>
		</TD>
		<TD WIDTH=415 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">RuntimeIdentifiers is used to
			identify target platforms where the application runs.</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=179 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Title:</FONT></P>
		</TD>
		<TD WIDTH=415 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Specify a name</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=179 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">GeneratePackageOnBuild:</FONT></P>
		</TD>
		<TD WIDTH=415 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Create a Nuget package on build</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=179 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Version:</FONT></P>
		</TD>
		<TD WIDTH=415 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Version of the package</FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=179 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">EnableDefaultCompileItems:</FONT></P>
		</TD>
		<TD WIDTH=415 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Cambria, serif">If you
			have globs in your project and you try to build it using the new
			SDK, you will get an error.</FONT></P>
			<P STYLE="margin-bottom: 0in"><BR>
			</P>
			<P><FONT FACE="Cambria, serif">To overcome this issue, set this
			property to false, which will override implicit inclusion and the
			behavior will revert back to the previous SDK where you had to
			specify the default globs in your project.</FONT></P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif"><B>Note</B></FONT><FONT FACE="Cambria, serif">:
Make necessary changes to the above code, for ex: if you have updated
you dll then you need to change the version, so that Nuget will have
a track of all the versions and user can choose which version he/she
wants to use.</FONT></P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif"><B>Note</B></FONT><FONT FACE="Cambria, serif">:
Target framework should also include the .net framework on which it
was developed apart from .net core and .net standard.</FONT></P>
<OL START=3>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Once
	you make those changes, Reload the project and rebuild it. </FONT>
	</P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">This
	will generate the .dll files and Nuget package for this build in the
	Debug/Release folder of the project.</FONT></P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Before
	we proceed to deploy the package to the Remote Nuget Server, we need
	to test this project locally to make sure it works without any
	issues.</FONT></P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">In
	order to test that, you need to copy the Nuget package to the &lt;Local
	Nuget&gt;.  </FONT>
	</P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Now
	create a test project and install the Nuget package that is deployed
	in the &lt;Local Nuget&gt;.</FONT></P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">If
	you have any issues installing the package or referencing the class
	properties or methods, fix the issues and re-test it.</FONT></P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">If
	the installation and referencing the project classes its methods and
	properties are successful, now you can proceed to deploy it on the
	Nuget.Server (which is in the cloud). </FONT>
	</P>
</OL>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<OL START=10>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">To
	Deploy the Nuget package on to the cloud you need to run the
	following command </FONT>
	</P>
</OL>
<TABLE WIDTH=575 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=69>
	<COL WIDTH=476>
	<TR VALIGN=TOP>
		<TD WIDTH=69 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Syntax:</FONT></P>
		</TD>
		<TD WIDTH=476 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT COLOR="#000000"><FONT FACE="Calibri, serif"><SPAN STYLE="font-weight: normal">nuget.exe
			push {package file} {apikey} -Source
			https://riskwarenugetserver.azurewebsites.net/nuget</SPAN></FONT></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=69 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Example:</FONT></P>
		</TD>
		<TD WIDTH=476 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in"><FONT FACE="Times New Roman, serif"><FONT SIZE=3>nuget.exe
			push S2.KeyReader.1.0.0.nupkg PanNugetDeploy123 -Source
			</FONT></FONT><A HREF="https://riskwarenugetserver.azurewebsites.net/nuget"><FONT COLOR="#0000ff"><FONT FACE="Times New Roman, serif"><FONT SIZE=3><U>https://riskwarenugetserver.azurewebsites.net/nuget</U></FONT></FONT></FONT></A></P>
			<P STYLE="font-weight: normal"><BR>
			</P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-left: 0.5in; margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif"><B>Note</B></FONT><FONT FACE="Cambria, serif">:
If the version of the package is already deployed, you can re-upload
the same package, you either have to change the version of the
package and re-upload or else delete the package from the Nuget
Server.</FONT></P>
<OL START=11>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Once
	you have deployed the package on to Nuget server, you can install
	the package in to your project by selecting the Package
	Source(Riskware Nuget Server) and installing the package.</FONT></P>
	<LI><P STYLE="margin-bottom: 0.11in"> <FONT FACE="Cambria, serif">If
	you want to delete the package, you can run the following command </FONT>
	</P>
</OL>
<TABLE WIDTH=623 CELLPADDING=7 CELLSPACING=0>
	<COL WIDTH=89>
	<COL WIDTH=505>
	<TR VALIGN=TOP>
		<TD WIDTH=89 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Syntax:</FONT></P>
		</TD>
		<TD WIDTH=505 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT COLOR="#222222"><SPAN STYLE="background: #f9f9f9">nuget.exe
			delete {your_package_id} {version} -Source {feed URL} -ApiKey key</SPAN></FONT></P>
		</TD>
	</TR>
	<TR VALIGN=TOP>
		<TD WIDTH=89 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P><FONT FACE="Cambria, serif">Example:</FONT></P>
		</TD>
		<TD WIDTH=505 STYLE="border: 1px solid #00000a; padding-top: 0in; padding-bottom: 0in; padding-left: 0.08in; padding-right: 0.08in">
			<P STYLE="margin-bottom: 0in">nuget.exe delete S2.KeyReader 1.0.0
			-ApiKey PanNugetDeploy123 -Source
			<A HREF="https://riskwarenugetserver.azurewebsites.net/nuget"><FONT COLOR="#0000ff"><U>https://riskwarenugetserver.azurewebsites.net/nuget</U></FONT></A></P>
			<P><BR>
			</P>
		</TD>
	</TR>
</TABLE>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in; border-top: none; border-bottom: 1px solid #00000a; border-left: none; border-right: none; padding-top: 0in; padding-bottom: 0.01in; padding-left: 0in; padding-right: 0in">
<BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif"><B>Steps
to port .Net framework project with dependencies to .Net Core Nuget
package</B></FONT></P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Before
we start implementing the steps to convert .net framework project
which has dependencies on other projects to a Nuget package which has
the .dll’s for required .net platforms. Let’s first discuss the
issue with this.</FONT></P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">As we
all know most of the projects that we develop or are developed by
others are dependent on other projects for their implementation. This
is basically done as a part of separation of concern. So creating a
Nuget package for the target project would fail to install. This is
because we haven’t referenced its project dependencies and Nuget or
visual studio is neither smart enough to create Nuget dependency
references for the project.</FONT></P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">To
resolve this issue, you need to create the Nuget package for
dependent projects that are linked to this project. Install the
dependent Nuget packages on the target project. Now create a Nuget
package for the target project. </FONT>
</P>
<P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">The
final Nuget package created for the target project can be deployed to
Nuget server and can be installed from the Nuget package manager. As
you can see the image below, </FONT><FONT FACE="Cambria, serif"><B>Project
A</B></FONT><FONT FACE="Cambria, serif"> project is dependent on
</FONT><FONT FACE="Cambria, serif"><B>Project B</B></FONT><FONT FACE="Cambria, serif">.
So now let’s implement this through a sample project.</FONT></P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><IMG style="float:left;width:142px;height:142px;" SRC="ImplementingNugetPackages_html_7225894a.gif"></P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<OL>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">First
	create a Nuget package for the </FONT><FONT FACE="Cambria, serif"><B>Project
	B</B></FONT><FONT FACE="Cambria, serif"> first, using the steps
	mentioned above.</FONT></P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Once
	you have created the package for </FONT><FONT FACE="Cambria, serif"><B>Project
	B</B></FONT><FONT FACE="Cambria, serif">, add the Nuget project to
	the Local Nuget Server.</FONT></P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Now
	on the </FONT><FONT FACE="Cambria, serif"><B>Project A</B></FONT><FONT FACE="Cambria, serif">,
	install the </FONT><FONT FACE="Cambria, serif"><B>Project B</B></FONT><FONT FACE="Cambria, serif">
	Nuget package using the Nuget package manager. </FONT>
	</P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">Create
	the Nuget package for </FONT><FONT FACE="Cambria, serif"><B>Project
	A</B></FONT><FONT FACE="Cambria, serif">, add the Nuget project to
	the Local Nuget Server.</FONT></P>
	<LI><P STYLE="margin-bottom: 0.11in"><FONT FACE="Cambria, serif">To
	this Nuget package, create .Net core console app project and install
	the </FONT><FONT FACE="Cambria, serif"><B>Project A</B></FONT><FONT FACE="Cambria, serif">
	Nuget package and use the </FONT><FONT FACE="Cambria, serif"><B>Project
	B</B></FONT><FONT FACE="Cambria, serif"> services that are linked to
	</FONT><FONT FACE="Cambria, serif"><B>Project A</B></FONT><FONT FACE="Cambria, serif">
	services.</FONT></P>
</OL>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
<P STYLE="margin-bottom: 0.11in"><BR><BR>
</P>
</BODY>
</HTML>
