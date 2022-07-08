# 生成RSA密钥
## 进入OpenSSL工具，输入以下命令：
> 1. OpenSSL> genrsa -out app_private_key.pem   2048  #生成私钥
> 2. OpenSSL> OpenSSL> pkcs8 -topk8 -inform PEM -in app_private_key.pem -outform PEM -nocrypt -out app_private_key_pkcs8.pem #Java开发者需要将私钥转换成PKCS8格式
> 3. OpenSSL> rsa -in app_private_key.pem -pubout -out app_public_key.pem #生成公钥
> 4. OpenSSL> exit #退出OpenSSL程序
### 经过以上步骤，可以在当前文件夹中（OpenSSL运行文件夹），看到 app_private_key.pem（开发者RSA私钥，非 Java 语言适用）、app_private_key_pkcs8.pem（pkcs8格式开发者RSA私钥，Java语言适用）和app_public_key.pem（开发者RSA公钥）3个文件。开发者将私钥保留，将公钥提交给支付宝配置到开发平台，用于验证签名。以下为私钥文件和公钥文件示例。
#### 说明：对于使用 Java 的开发者，需将生成的 pkcs8 格式的私钥去除头尾、换行和空格，作为私钥填入代码中，对于.NET和PHP的开发者来说，无需进行 pkcs8 命令行操作。
