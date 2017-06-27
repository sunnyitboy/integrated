 关于System.Web.Script.Serialization命名空间的引用

解决方案：


首先在目录中找到C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.5\System.Web.Extensions.dll

将该文件添加至项目的bin文件夹下

再次右击项目属性，在应用程序-目标框架下，选择.netFramework4

最后，引用添加该dll文件即可。
