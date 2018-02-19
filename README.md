# C# 新浪微博二维码扫码登录
在代码里都写好注释了，直接用Visual Studio打开就好了

## 其他
* 在 `login` 函数中有注释，如果需要获取微博登录后的`Cookies`，可以修改`HTTP`类中的`Get`，然后获取到登陆以后的Cookies  

* 代码中判断二维码是否使用，采用了 `timer 时间控件` 在一定的情况下（网速不好等等），可能会造成卡顿  

* 另外在使用`alt`提交登陆的返回中  
`{"retcode":"0","uid":$uid,"nick":$nick,"crossDomainUrlList":["https:\/\/passport.97973.com\/sso\/crossdomain?action=login&savestate=$ssosavestate","https:\/\/passport.krcom.cn\/sso\/crossdomain?service=$service&savestate=$savestate&ticket=$ticket&ssosavestate=$ssosavestate","https:\/\/passport.weibo.cn\/sso\/crossdomain?action=login&savestate=1","https:\/\/passport.weibo.com\/wbsso\/login?ticket=$ticket&ssosavestate=$ssosavestate"]}`  
`crossDomainUrlList[3]`的`value`在没有登录微博的情况下，直接访问，会登录并跳转到扫码的微博的个人主页  

* 其他的请参照代码里的注释
