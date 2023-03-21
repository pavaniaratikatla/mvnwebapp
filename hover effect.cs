*{
    padding:0;
    margin:0;
    box-sizing: border-box;
}
body{
    background-color:antiquewhite;
}
.container{
    width:40%;
    height:400px;
    position:absolute;
    top: 50%;
    left:50%;
    transform:translate(-50%,-50%);
    box-shadow: 0 10px 20px black;
}
img{
    height:100%;
    width:100%;
}
.overlay{
    position: absolute;
    top: 0;
    left: 0;
    right:0;
    bottom:0;
    opacity:0;
    transition :opacity 0.4s ease-in-out;
    background-color: black;
    cursor: pointer;
}
.content{
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    color: white;
    font-family: 'Times New Roman', Times, serif;
    text-align: center;
}
.container:hover .overlay{
    opacity: 0.8;
}
