### H2Chain-boilerplate-java搭建

------

#### 1. 关于项目路径介绍：

- io.aelf：java-sdk需要的资源
- contractUtil：封装了状态获取的API以及合约部署调用的API
- **H2ChainUtil：**
  - HexUtil：hex解码API
  - OSS：jar上传OSS API
- **contractImpl：**
  - Implement：合约逻辑编写目录
  - State：合约所需状态定义（后期迭代可以使用proto，脚本自动编译成java类来实现）
