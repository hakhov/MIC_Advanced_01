

var video = new Video()
{
    Title = "Menq enq mer sarer@!!!",
    Duration = 250
};

var videoConvertor = new VideoConvertor();
var mailService = new MailService();
var messageService = new MessageService();

videoConvertor.VideoConvertedEvent += mailService.OnEmailSent;
videoConvertor.VideoConvertedEvent += messageService.OnMessageSent;
videoConvertor.Convertor(video);
