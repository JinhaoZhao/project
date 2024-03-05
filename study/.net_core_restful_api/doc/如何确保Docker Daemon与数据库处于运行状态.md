# 如何确保Docker Daemon与数据库处于运行状态

## 前提：
<font size=3 color=red>需要预先完成课程的<font size=5>第三章第五节</font></font>

## 1. 检查docker服务是否运行
### Windows:
点击任务栏的隐藏/显示按钮, 确认 docker 的小鲸鱼图标正在运行。如果看不到这个图标则表示docker服务没有运行，继续执行第二步“运行docker服务”，否则可以直接跳到第三步
![`.NET Core`](https://s1.ax1x.com/2020/07/05/USVScF.jpg)
### MAC 
在顶部任务栏中确认确认 docker 的小鲸鱼图标正在运行。如果看不到这个图标则表示docker服务没有运行，继续执行第二步“运行docker服务”，否则可以直接跳到第三步
![`.NET Core`](https://s1.ax1x.com/2020/07/05/USVHgO.png)

## 2. 运行docker服务
### Windows:
搜索并运行 “Docker Desktop” 应用程序
![`.NET Core`](https://s1.ax1x.com/2020/07/05/USVe1O.jpg)
然后再任务栏中会看到小鲸鱼图标，“Docker Desktop is starting”
![`.NET Core`](https://s1.ax1x.com/2020/07/05/USVnje.jpg)

### MAC 
在应用列表中找到小鲸鱼，点击运行
![`.NET Core`](https://s1.ax1x.com/2020/07/05/USVbvD.png)

## 2. 检查数据库是否运行正常
运行 `docker ps`

如果看到空列表，则代码数据库没有运行，需要继续执行第三步
![`.NET Core`](https://s1.ax1x.com/2020/07/05/USVQHA.jpg)

如果看到docker容器列表中有mssql-server-linux，则代表数据库正常运行了。<font color=green>那么，恭喜你，你的docker服务与数据库都处于正常运行状态</font>
![`.NET Core`](https://s1.ax1x.com/2020/07/05/USVY38.jpg)


## 3.运行数据库
### 1. 运行 `docker ps -a`，检查docker容器的历史记录，找到`mssql-server-linux`所对应的容器id
![`.NET Core`](https://s1.ax1x.com/2020/07/05/USVyCV.jpg)
### 2. 运行 `mssql-server-linux`所对应的容器id：`docker start 833322134ec1`
![`.NET Core`](https://s1.ax1x.com/2020/07/05/USVgvF.jpg)
### 2. 最后运行 `docker ps`，再次检查数据库是否正常运行

