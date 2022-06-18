using Rebu;
using System.Collections.Generic;

namespace RebuApp.Services
{
    public class DriverService
    {
        // db
        List<Driver> drivers = new List<Driver> {
            new Driver
            {

                Id = "dec5dc97-5dd6-4316-bf05-4064ab42c437",
                Name = "Ewen Fetherston",
                Photo = "http=//ftc.gov/orci/vehicula.jpg?neque=donec&sapien=posuere&placerat=metus&ante=vitae&nulla=ipsum&justo=aliquam&aliquam=non&quis=mauris&turpis=morbi&eget=non&elit=lectus&sodales=aliquam&scelerisque=sit&mauris=amet&sit=diam&amet=in&eros=magna",
                Phone = "353-826-5625",
                Avalible = false
            }, new Driver
            {
                Id = "9a592f1a-368b-40ef-993a-abfbbb71454c",
                Name = "Shelden Saines",
                Photo = "https=//lulu.com/adipiscing/elit/proin/interdum/mauris/non.json?risus=commodo&auctor=placerat",
                Phone = "930-546-5484",
                Avalible = false
            }, new Driver
            {
                Id = "30abc055-b80a-4d67-9e46-f38e2296792e",
                Name = "Marji Buckenhill",
                Photo = "http=//studiopress.com/nam/ultrices/libero.html?id=est&nisl=risus&venenatis=auctor&lacinia=sed&aenean=tristique&sit=in&amet=tempus&justo=sit&morbi=amet&ut=sem&odio=fusce&cras=consequat&mi=nulla&pede=nisl&malesuada=nunc&in=nisl&imperdiet=duis&et=bibendum&commodo=felis&vulputate=sed&justo=interdum&in=venenatis&blandit=turpis&ultrices=enim&enim=blandit&lorem=mi&ipsum=in&dolor=porttitor&sit=pede&amet=justo&consectetuer=eu&adipiscing=massa&elit=donec&proin=dapibus&interdum=duis&mauris=at&non=velit&ligula=eu&pellentesque=est&ultrices=congue&phasellus=elementum&id=in&sapien=hac&in=habitasse&sapien=platea&iaculis=dictumst&congue=morbi&vivamus=vestibulum&metus=velit&arcu=id&adipiscing=pretium",
                Phone = "793-512-2788",
                Avalible = true
            }, new Driver
            {
                Id = "fdf059c8-b51d-41ed-831f-a6501db2a465",
                Name = "Gerard Peele",
                Photo = "http=//webmd.com/ultrices/aliquet/maecenas/leo.js?interdum=dictumst&in=maecenas&ante=ut&vestibulum=massa&ante=quis&ipsum=augue&primis=luctus&in=tincidunt&faucibus=nulla&orci=mollis&luctus=molestie&et=lorem&ultrices=quisque&posuere=ut&cubilia=erat&curae=curabitur&duis=gravida&faucibus=nisi&accumsan=at&odio=nibh&curabitur=in&convallis=hac&duis=habitasse&consequat=platea&dui=dictumst&nec=aliquam&nisi=augue&volutpat=quam&eleifend=sollicitudin&donec=vitae&ut=consectetuer&dolor=eget&morbi=rutrum&vel=at&lectus=lorem&in=integer&quam=tincidunt&fringilla=ante&rhoncus=vel&mauris=ipsum&enim=praesent&leo=blandit&rhoncus=lacinia&sed=erat&vestibulum=vestibulum&sit=sed&amet=magna&cursus=at&id=nunc&turpis=commodo&integer=placerat&aliquet=praesent&massa=blandit&id=nam&lobortis=nulla&convallis=integer&tortor=pede",
                Phone = "642-860-7518",
                Avalible = true
            }, new Driver
            {
                Id = "3d36d03e-1c2c-4a75-8f6a-93ef0313b5c4",
                Name = "Matilde Bowland",
                Photo = "https=//amazon.co.jp/habitasse/platea/dictumst/etiam/faucibus/cursus/urna.aspx?in=justo&felis=in&eu=hac&sapien=habitasse&cursus=platea&vestibulum=dictumst&proin=etiam&eu=faucibus&mi=cursus&nulla=urna&ac=ut&enim=tellus&in=nulla&tempor=ut&turpis=erat&nec=id",
                Phone = "166-786-5714",
                Avalible = true
            }, new Driver
            {
                Id = "1c286d52-1913-4cb4-8a04-5299382a1139",
                Name = "Lorianna Proudler",
                Photo = "http=//weebly.com/neque/vestibulum/eget.json?donec=integer&quis=aliquet&orci=massa&eget=id&orci=lobortis&vehicula=convallis&condimentum=tortor&curabitur=risus&in=dapibus&libero=augue&ut=vel&massa=accumsan&volutpat=tellus&convallis=nisi&morbi=eu&odio=orci&odio=mauris&elementum=lacinia&eu=sapien&interdum=quis&eu=libero&tincidunt=nullam&in=sit&leo=amet",
                Phone = "870-414-5983",
                Avalible = true
            }, new Driver
            {
                Id = "1d054831-0212-478f-9ede-2ebe20a228dc",
                Name = "Shawn Eberst",
                Photo = "http=//stanford.edu/vitae/mattis.js?nec=id&condimentum=nisl&neque=venenatis&sapien=lacinia&placerat=aenean&ante=sit&nulla=amet&justo=justo&aliquam=morbi&quis=ut&turpis=odio&eget=cras&elit=mi&sodales=pede&scelerisque=malesuada&mauris=in&sit=imperdiet&amet=et&eros=commodo&suspendisse=vulputate&accumsan=justo&tortor=in&quis=blandit&turpis=ultrices&sed=enim&ante=lorem",
                Phone = "843-475-2396",
                Avalible = false
            }, new Driver
            {
                Id = "9f7a953a-af46-4a8c-9bde-86b325e6e3c8",
                Name = "Nita Isaacson",
                Photo = "http=//instagram.com/consequat/metus.aspx?vitae=sapien&consectetuer=cum&eget=sociis&rutrum=natoque&at=penatibus&lorem=et&integer=magnis&tincidunt=dis&ante=parturient&vel=montes",
                Phone = "897-928-7531",
                Avalible = true
            }, new Driver
            {
                Id = "5d3e1d8a-a788-49b2-b7d5-17ddb1d7d169",
                Name = "Diane Crumpton",
                Photo = "http=//wikimedia.org/morbi/ut/odio/cras/mi/pede/malesuada.png?auctor=vitae&gravida=nisi&sem=nam&praesent=ultrices&id=libero&massa=non&id=mattis&nisl=pulvinar&venenatis=nulla&lacinia=pede&aenean=ullamcorper&sit=augue&amet=a&justo=suscipit&morbi=nulla&ut=elit&odio=ac&cras=nulla&mi=sed&pede=vel&malesuada=enim&in=sit&imperdiet=amet&et=nunc&commodo=viverra&vulputate=dapibus&justo=nulla&in=suscipit&blandit=ligula&ultrices=in&enim=lacus&lorem=curabitur&ipsum=at&dolor=ipsum&sit=ac&amet=tellus&consectetuer=semper&adipiscing=interdum&elit=mauris&proin=ullamcorper&interdum=purus&mauris=sit&non=amet&ligula=nulla&pellentesque=quisque&ultrices=arcu&phasellus=libero&id=rutrum&sapien=ac&in=lobortis&sapien=vel",
                Phone = "379-476-4431",
                Avalible = false
            }, new Driver
            {
                Id = "ac3f3e25-2d09-4d14-af38-21c88da68cdf",
                Name = "Sharl Stoyles",
                Photo = "https=//mail.ru/nunc/rhoncus/dui/vel/sem.jpg?dignissim=vitae&vestibulum=nisl&vestibulum=aenean&ante=lectus&ipsum=pellentesque&primis=eget&in=nunc&faucibus=donec&orci=quis&luctus=orci&et=eget&ultrices=orci&posuere=vehicula&cubilia=condimentum&curae=curabitur&nulla=in&dapibus=libero&dolor=ut&vel=massa&est=volutpat&donec=convallis&odio=morbi&justo=odio&sollicitudin=odio&ut=elementum&suscipit=eu&a=interdum&feugiat=eu&et=tincidunt&eros=in&vestibulum=leo&ac=maecenas&est=pulvinar&lacinia=lobortis&nisi=est&venenatis=phasellus&tristique=sit&fusce=amet&congue=erat&diam=nulla&id=tempus",
                Phone = "548-275-8881",
                Avalible = true
            }, new Driver
            {
                Id = "9f5feb83-f670-4a7b-98cc-8261bafc6a56",
                Name = "Romola McMillam",
                Photo = "http=//gizmodo.com/morbi/ut/odio/cras/mi/pede.json?morbi=eu&non=interdum&quam=eu&nec=tincidunt&dui=in&luctus=leo&rutrum=maecenas&nulla=pulvinar&tellus=lobortis&in=est&sagittis=phasellus&dui=sit&vel=amet&nisl=erat&duis=nulla&ac=tempus&nibh=vivamus&fusce=in&lacus=felis&purus=eu&aliquet=sapien&at=cursus&feugiat=vestibulum&non=proin&pretium=eu&quis=mi&lectus=nulla&suspendisse=ac&potenti=enim&in=in&eleifend=tempor&quam=turpis&a=nec&odio=euismod&in=scelerisque&hac=quam&habitasse=turpis&platea=adipiscing&dictumst=lorem&maecenas=vitae&ut=mattis&massa=nibh&quis=ligula&augue=nec&luctus=sem&tincidunt=duis&nulla=aliquam&mollis=convallis&molestie=nunc&lorem=proin&quisque=at",
                Phone = "605-843-0110",
                Avalible = false
            }, new Driver
            {
                Id = "4702b1e7-f386-4644-82de-d07fe4d9b01e",
                Name = "Ada Fear",
                Photo = "http=//acquirethisname.com/luctus/nec/molestie/sed.jpg?maecenas=ridiculus&tristique=mus&est=vivamus&et=vestibulum&tempus=sagittis&semper=sapien&est=cum&quam=sociis&pharetra=natoque&magna=penatibus&ac=et&consequat=magnis&metus=dis&sapien=parturient&ut=montes&nunc=nascetur&vestibulum=ridiculus&ante=mus&ipsum=etiam&primis=vel&in=augue&faucibus=vestibulum&orci=rutrum&luctus=rutrum&et=neque&ultrices=aenean&posuere=auctor&cubilia=gravida&curae=sem&mauris=praesent&viverra=id&diam=massa&vitae=id&quam=nisl&suspendisse=venenatis&potenti=lacinia&nullam=aenean&porttitor=sit&lacus=amet&at=justo&turpis=morbi&donec=ut&posuere=odio&metus=cras&vitae=mi&ipsum=pede&aliquam=malesuada&non=in&mauris=imperdiet&morbi=et&non=commodo&lectus=vulputate&aliquam=justo&sit=in&amet=blandit&diam=ultrices&in=enim&magna=lorem&bibendum=ipsum&imperdiet=dolor&nullam=sit&orci=amet",
                Phone = "439-772-1109",
                Avalible = false
            }, new Driver
            {
                Id = "17c9916e-a2ff-4fd9-8e1a-50e26c1605b6",
                Name = "Siegfried McConaghy",
                Photo = "https=//berkeley.edu/ut/volutpat/sapien/arcu/sed/augue.jsp?amet=eu&lobortis=tincidunt&sapien=in&sapien=leo&non=maecenas&mi=pulvinar&integer=lobortis&ac=est&neque=phasellus&duis=sit&bibendum=amet&morbi=erat&non=nulla&quam=tempus&nec=vivamus&dui=in&luctus=felis&rutrum=eu&nulla=sapien&tellus=cursus&in=vestibulum&sagittis=proin&dui=eu&vel=mi&nisl=nulla&duis=ac&ac=enim&nibh=in&fusce=tempor&lacus=turpis&purus=nec&aliquet=euismod&at=scelerisque&feugiat=quam&non=turpis&pretium=adipiscing&quis=lorem&lectus=vitae&suspendisse=mattis&potenti=nibh&in=ligula&eleifend=nec&quam=sem&a=duis&odio=aliquam&in=convallis&hac=nunc&habitasse=proin&platea=at&dictumst=turpis&maecenas=a&ut=pede&massa=posuere&quis=nonummy&augue=integer&luctus=non&tincidunt=velit&nulla=donec&mollis=diam&molestie=neque&lorem=vestibulum&quisque=eget&ut=vulputate&erat=ut&curabitur=ultrices&gravida=vel&nisi=augue&at=vestibulum&nibh=ante&in=ipsum&hac=primis&habitasse=in&platea=faucibus&dictumst=orci&aliquam=luctus&augue=et&quam=ultrices&sollicitudin=posuere&vitae=cubilia&consectetuer=curae&eget=donec&rutrum=pharetra&at=magna",
                Phone = "374-106-7653",
                Avalible = true
            }, new Driver
            {
                Id = "28ead4ed-3f87-4c62-8099-9317e9d975b6",
                Name = "Cristen Kirsche",
                Photo = "https=//fastcompany.com/mauris/lacinia.jsp?volutpat=lacus&erat=morbi&quisque=sem&erat=mauris&eros=laoreet&viverra=ut&eget=rhoncus&congue=aliquet&eget=pulvinar&semper=sed&rutrum=nisl&nulla=nunc&nunc=rhoncus&purus=dui&phasellus=vel&in=sem&felis=sed&donec=sagittis&semper=nam&sapien=congue&a=risus&libero=semper&nam=porta&dui=volutpat&proin=quam&leo=pede&odio=lobortis&porttitor=ligula&id=sit&consequat=amet&in=eleifend&consequat=pede&ut=libero&nulla=quis&sed=orci&accumsan=nullam&felis=molestie&ut=nibh&at=in&dolor=lectus&quis=pellentesque&odio=at",
                Phone = "415-243-0956",
                Avalible = true
            }, new Driver
            {
                Id = "8b979a2b-4cbf-43e8-b1ee-dcd89d8366bf",
                Name = "Malissa Barrott",
                Photo = "https=//about.com/lacinia/sapien/quis/libero/nullam/sit/amet.html?eleifend=tellus&luctus=in&ultricies=sagittis&eu=dui&nibh=vel&quisque=nisl&id=duis&justo=ac&sit=nibh&amet=fusce&sapien=lacus&dignissim=purus&vestibulum=aliquet&vestibulum=at&ante=feugiat&ipsum=non&primis=pretium&in=quis&faucibus=lectus&orci=suspendisse&luctus=potenti&et=in&ultrices=eleifend&posuere=quam&cubilia=a&curae=odio&nulla=in&dapibus=hac&dolor=habitasse&vel=platea&est=dictumst&donec=maecenas&odio=ut&justo=massa&sollicitudin=quis&ut=augue&suscipit=luctus&a=tincidunt&feugiat=nulla&et=mollis&eros=molestie&vestibulum=lorem&ac=quisque&est=ut&lacinia=erat&nisi=curabitur&venenatis=gravida&tristique=nisi&fusce=at&congue=nibh&diam=in&id=hac&ornare=habitasse&imperdiet=platea&sapien=dictumst&urna=aliquam&pretium=augue&nisl=quam&ut=sollicitudin&volutpat=vitae&sapien=consectetuer&arcu=eget&sed=rutrum&augue=at&aliquam=lorem&erat=integer&volutpat=tincidunt&in=ante&congue=vel&etiam=ipsum&justo=praesent&etiam=blandit&pretium=lacinia&iaculis=erat&justo=vestibulum&in=sed&hac=magna",
                Phone = "290-738-0281",
                Avalible = false
            }, new Driver
            {
                Id = "3e16f7b3-e118-485b-8f14-cb57fe850430",
                Name = "Rita Leal",
                Photo = "https=//etsy.com/semper/sapien/a/libero/nam.xml?id=metus&justo=arcu&sit=adipiscing&amet=molestie&sapien=hendrerit&dignissim=at&vestibulum=vulputate&vestibulum=vitae&ante=nisl&ipsum=aenean&primis=lectus&in=pellentesque&faucibus=eget&orci=nunc&luctus=donec&et=quis&ultrices=orci&posuere=eget&cubilia=orci&curae=vehicula&nulla=condimentum&dapibus=curabitur&dolor=in&vel=libero&est=ut&donec=massa&odio=volutpat&justo=convallis&sollicitudin=morbi&ut=odio&suscipit=odio&a=elementum&feugiat=eu&et=interdum&eros=eu&vestibulum=tincidunt&ac=in&est=leo&lacinia=maecenas&nisi=pulvinar&venenatis=lobortis&tristique=est&fusce=phasellus&congue=sit&diam=amet&id=erat&ornare=nulla&imperdiet=tempus&sapien=vivamus&urna=in&pretium=felis&nisl=eu&ut=sapien&volutpat=cursus&sapien=vestibulum&arcu=proin&sed=eu&augue=mi&aliquam=nulla&erat=ac&volutpat=enim",
                Phone = "876-753-2882",
                Avalible = true
            }, new Driver
            {
                Id = "ba3a39d8-2ecd-41aa-831c-69d05b2ed28c",
                Name = "Darrelle Bartholomew",
                Photo = "https=//fda.gov/at.aspx?mattis=orci&egestas=nullam&metus=molestie&aenean=nibh&fermentum=in&donec=lectus&ut=pellentesque&mauris=at&eget=nulla&massa=suspendisse&tempor=potenti&convallis=cras&nulla=in&neque=purus&libero=eu&convallis=magna&eget=vulputate&eleifend=luctus&luctus=cum&ultricies=sociis&eu=natoque&nibh=penatibus&quisque=et&id=magnis&justo=dis&sit=parturient&amet=montes&sapien=nascetur&dignissim=ridiculus&vestibulum=mus&vestibulum=vivamus&ante=vestibulum&ipsum=sagittis&primis=sapien&in=cum&faucibus=sociis&orci=natoque&luctus=penatibus&et=et&ultrices=magnis&posuere=dis&cubilia=parturient&curae=montes&nulla=nascetur&dapibus=ridiculus&dolor=mus&vel=etiam&est=vel&donec=augue&odio=vestibulum&justo=rutrum&sollicitudin=rutrum&ut=neque&suscipit=aenean&a=auctor&feugiat=gravida&et=sem&eros=praesent",
                Phone = "664-153-2256",
                Avalible = true
            }, new Driver
            {
                Id = "347aaeb3-6bfc-4558-9b08-f7eab8a98460",
                Name = "Emogene Scherme",
                Photo = "https=//csmonitor.com/aliquam/convallis/nunc/proin.jsp?vestibulum=condimentum&quam=neque&sapien=sapien&varius=placerat",
                Phone = "399-959-7698",
                Avalible = false
            }, new Driver
            {
                Id = "4f3e2f23-ae3e-460d-b0b1-616af1e6534a",
                Name = "Hedvige Botha",
                Photo = "https=//xing.com/at/diam/nam.html?a=leo&nibh=odio&in=condimentum&quis=id&justo=luctus&maecenas=nec&rhoncus=molestie&aliquam=sed&lacus=justo&morbi=pellentesque&quis=viverra&tortor=pede&id=ac&nulla=diam&ultrices=cras&aliquet=pellentesque&maecenas=volutpat&leo=dui&odio=maecenas&condimentum=tristique&id=est&luctus=et&nec=tempus&molestie=semper&sed=est&justo=quam&pellentesque=pharetra&viverra=magna&pede=ac&ac=consequat&diam=metus&cras=sapien&pellentesque=ut&volutpat=nunc&dui=vestibulum&maecenas=ante&tristique=ipsum&est=primis&et=in&tempus=faucibus&semper=orci&est=luctus&quam=et&pharetra=ultrices&magna=posuere&ac=cubilia&consequat=curae&metus=mauris&sapien=viverra&ut=diam&nunc=vitae&vestibulum=quam&ante=suspendisse&ipsum=potenti&primis=nullam&in=porttitor&faucibus=lacus&orci=at&luctus=turpis&et=donec&ultrices=posuere&posuere=metus&cubilia=vitae&curae=ipsum&mauris=aliquam&viverra=non&diam=mauris&vitae=morbi&quam=non&suspendisse=lectus&potenti=aliquam&nullam=sit&porttitor=amet&lacus=diam&at=in&turpis=magna&donec=bibendum&posuere=imperdiet&metus=nullam&vitae=orci&ipsum=pede&aliquam=venenatis&non=non&mauris=sodales&morbi=sed&non=tincidunt&lectus=eu&aliquam=felis&sit=fusce&amet=posuere&diam=felis&in=sed&magna=lacus&bibendum=morbi&imperdiet=sem&nullam=mauris&orci=laoreet&pede=ut&venenatis=rhoncus&non=aliquet",
                Phone = "298-816-6592",
                Avalible = false
            }, new Driver
            {
                Id = "d6ab40df-35ec-47c2-b2d7-10214ea26354",
                Name = "Cirillo Werrett",
                Photo = "http=//wunderground.com/nisl.jpg?sit=condimentum&amet=neque&eros=sapien&suspendisse=placerat&accumsan=ante&tortor=nulla&quis=justo&turpis=aliquam&sed=quis&ante=turpis&vivamus=eget&tortor=elit&duis=sodales&mattis=scelerisque&egestas=mauris&metus=sit&aenean=amet&fermentum=eros&donec=suspendisse&ut=accumsan&mauris=tortor&eget=quis&massa=turpis&tempor=sed&convallis=ante&nulla=vivamus&neque=tortor&libero=duis&convallis=mattis&eget=egestas&eleifend=metus&luctus=aenean&ultricies=fermentum&eu=donec&nibh=ut&quisque=mauris&id=eget&justo=massa&sit=tempor&amet=convallis&sapien=nulla&dignissim=neque&vestibulum=libero&vestibulum=convallis&ante=eget&ipsum=eleifend&primis=luctus&in=ultricies&faucibus=eu&orci=nibh&luctus=quisque&et=id&ultrices=justo&posuere=sit&cubilia=amet&curae=sapien&nulla=dignissim&dapibus=vestibulum&dolor=vestibulum&vel=ante&est=ipsum&donec=primis&odio=in&justo=faucibus&sollicitudin=orci&ut=luctus&suscipit=et&a=ultrices&feugiat=posuere&et=cubilia&eros=curae&vestibulum=nulla&ac=dapibus&est=dolor&lacinia=vel&nisi=est&venenatis=donec&tristique=odio&fusce=justo&congue=sollicitudin&diam=ut&id=suscipit&ornare=a&imperdiet=feugiat&sapien=et&urna=eros&pretium=vestibulum",
                Phone = "312-700-5976",
                Avalible = true
            }, new Driver
            {
                Id = "14a87e26-6b2d-4002-8a95-ac2474c2e622",
                Name = "Eleen Gosnell",
                Photo = "http=//skype.com/viverra/eget/congue/eget/semper/rutrum.js?augue=consequat&aliquam=varius&erat=integer&volutpat=ac&in=leo&congue=pellentesque&etiam=ultrices&justo=mattis&etiam=odio&pretium=donec&iaculis=vitae&justo=nisi&in=nam",
                Phone = "301-367-9761",
                Avalible = true
            }, new Driver
            {
                Id = "a774ad78-8cc8-409c-95b7-9d2a1f643dfe",
                Name = "Elke Tomsett",
                Photo = "http=//Photobucket.com/at/turpis/a.json?amet=tortor&diam=quis&in=turpis&magna=sed&bibendum=ante&imperdiet=vivamus&nullam=tortor&orci=duis&pede=mattis&venenatis=egestas&non=metus&sodales=aenean&sed=fermentum&tincidunt=donec&eu=ut&felis=mauris&fusce=eget&posuere=massa&felis=tempor&sed=convallis&lacus=nulla&morbi=neque&sem=libero&mauris=convallis&laoreet=eget&ut=eleifend&rhoncus=luctus&aliquet=ultricies&pulvinar=eu&sed=nibh&nisl=quisque&nunc=id&rhoncus=justo&dui=sit&vel=amet&sem=sapien&sed=dignissim&sagittis=vestibulum&nam=vestibulum&congue=ante&risus=ipsum&semper=primis&porta=in&volutpat=faucibus&quam=orci",
                Phone = "630-621-3276",
                Avalible = true
            }, new Driver
            {
                Id = "41ad728e-7854-4c68-9f45-9c2ea24b0a9e",
                Name = "Jacquelynn Cossum",
                Photo = "http=//gmpg.org/libero/nullam/sit/amet/turpis/elementum/ligula.png?sem=sagittis&sed=nam&sagittis=congue&nam=risus&congue=semper&risus=porta&semper=volutpat&porta=quam&volutpat=pede&quam=lobortis&pede=ligula&lobortis=sit&ligula=amet&sit=eleifend&amet=pede&eleifend=libero&pede=quis&libero=orci&quis=nullam&orci=molestie&nullam=nibh",
                Phone = "522-677-1644",
                Avalible = false
            }, new Driver
            {
                Id = "3a6d6382-44a1-4ded-9072-c37c4a7ca0ed",
                Name = "Lucky Tommasetti",
                Photo = "https=//mediafire.com/praesent/blandit/lacinia/erat.js?at=quisque",
                Phone = "426-748-2055",
                Avalible = true
            }, new Driver
            {
                Id = "9a444ed5-b6a8-4c38-b386-61a96ae5324d",
                Name = "Vidovik Pickston",
                Photo = "http=//ocn.ne.jp/erat/curabitur/gravida/nisi/at/nibh.jsp?parturient=libero&montes=nam&nascetur=dui&ridiculus=proin&mus=leo&vivamus=odio&vestibulum=porttitor&sagittis=id&sapien=consequat&cum=in&sociis=consequat&natoque=ut&penatibus=nulla&et=sed&magnis=accumsan&dis=felis&parturient=ut&montes=at&nascetur=dolor&ridiculus=quis&mus=odio&etiam=consequat&vel=varius&augue=integer&vestibulum=ac&rutrum=leo&rutrum=pellentesque&neque=ultrices&aenean=mattis&auctor=odio&gravida=donec&sem=vitae&praesent=nisi&id=nam&massa=ultrices&id=libero&nisl=non&venenatis=mattis&lacinia=pulvinar&aenean=nulla&sit=pede&amet=ullamcorper&justo=augue&morbi=a&ut=suscipit&odio=nulla&cras=elit&mi=ac&pede=nulla&malesuada=sed&in=vel&imperdiet=enim&et=sit&commodo=amet&vulputate=nunc&justo=viverra&in=dapibus&blandit=nulla&ultrices=suscipit&enim=ligula&lorem=in&ipsum=lacus&dolor=curabitur&sit=at&amet=ipsum&consectetuer=ac&adipiscing=tellus&elit=semper&proin=interdum&interdum=mauris&mauris=ullamcorper&non=purus&ligula=sit&pellentesque=amet&ultrices=nulla&phasellus=quisque&id=arcu&sapien=libero&in=rutrum&sapien=ac&iaculis=lobortis&congue=vel&vivamus=dapibus&metus=at&arcu=diam",
                Phone = "563-993-0095",
                Avalible = true
            }, new Driver
            {
                Id = "c2f536bf-947e-4622-87be-dbd78dbbd504",
                Name = "Leora Letten",
                Photo = "https=//smugmug.com/metus/vitae.html?morbi=nisl&vel=nunc&lectus=rhoncus&in=dui&quam=vel&fringilla=sem&rhoncus=sed&mauris=sagittis&enim=nam",
                Phone = "623-120-4397",
                Avalible = false
            }, new Driver
            {
                Id = "aa0329cd-f5d3-4ac6-8e0c-5ea964f035f1",
                Name = "Gabriello Fautly",
                Photo = "http=//dedecms.com/pulvinar.aspx?nulla=odio&justo=in&aliquam=hac&quis=habitasse&turpis=platea&eget=dictumst&elit=maecenas&sodales=ut&scelerisque=massa&mauris=quis&sit=augue&amet=luctus&eros=tincidunt&suspendisse=nulla&accumsan=mollis&tortor=molestie&quis=lorem&turpis=quisque&sed=ut&ante=erat&vivamus=curabitur&tortor=gravida&duis=nisi&mattis=at&egestas=nibh&metus=in&aenean=hac&fermentum=habitasse&donec=platea&ut=dictumst&mauris=aliquam&eget=augue&massa=quam&tempor=sollicitudin&convallis=vitae&nulla=consectetuer&neque=eget&libero=rutrum&convallis=at",
                Phone = "598-979-7132",
                Avalible = false
            }, new Driver
            {
                Id = "b779851f-3703-4cbe-8b27-7d9f1b4ee054",
                Name = "Rakel Dabbs",
                Photo = "https=//altervista.org/fermentum/justo/nec.xml?consequat=curabitur&metus=in&sapien=libero&ut=ut&nunc=massa&vestibulum=volutpat&ante=convallis&ipsum=morbi&primis=odio&in=odio&faucibus=elementum&orci=eu&luctus=interdum&et=eu&ultrices=tincidunt&posuere=in&cubilia=leo&curae=maecenas&mauris=pulvinar&viverra=lobortis&diam=est&vitae=phasellus&quam=sit&suspendisse=amet&potenti=erat&nullam=nulla&porttitor=tempus&lacus=vivamus&at=in&turpis=felis&donec=eu&posuere=sapien&metus=cursus&vitae=vestibulum&ipsum=proin&aliquam=eu&non=mi&mauris=nulla&morbi=ac&non=enim&lectus=in&aliquam=tempor&sit=turpis&amet=nec&diam=euismod&in=scelerisque&magna=quam&bibendum=turpis&imperdiet=adipiscing&nullam=lorem&orci=vitae&pede=mattis&venenatis=nibh&non=ligula&sodales=nec&sed=sem&tincidunt=duis&eu=aliquam&felis=convallis&fusce=nunc&posuere=proin&felis=at&sed=turpis&lacus=a&morbi=pede&sem=posuere&mauris=nonummy&laoreet=integer&ut=non&rhoncus=velit&aliquet=donec&pulvinar=diam&sed=neque&nisl=vestibulum&nunc=eget&rhoncus=vulputate&dui=ut&vel=ultrices&sem=vel&sed=augue&sagittis=vestibulum&nam=ante&congue=ipsum&risus=primis&semper=in&porta=faucibus",
                Phone = "235-457-0954",
                Avalible = true
            }, new Driver
            {
                Id = "e370c92f-9dcd-48ab-85a5-593cdf3b567a",
                Name = "Thaxter Peagrim",
                Photo = "http=//usda.gov/porttitor/id/consequat/in/consequat.json?ultrices=proin&posuere=at&cubilia=turpis&curae=a&nulla=pede&dapibus=posuere&dolor=nonummy&vel=integer&est=non&donec=velit&odio=donec&justo=diam&sollicitudin=neque&ut=vestibulum&suscipit=eget&a=vulputate&feugiat=ut&et=ultrices&eros=vel&vestibulum=augue&ac=vestibulum&est=ante&lacinia=ipsum&nisi=primis&venenatis=in&tristique=faucibus&fusce=orci&congue=luctus&diam=et&id=ultrices&ornare=posuere&imperdiet=cubilia&sapien=curae&urna=donec&pretium=pharetra&nisl=magna&ut=vestibulum&volutpat=aliquet&sapien=ultrices&arcu=erat&sed=tortor&augue=sollicitudin&aliquam=mi&erat=sit&volutpat=amet&in=lobortis&congue=sapien&etiam=sapien&justo=non&etiam=mi&pretium=integer&iaculis=ac&justo=neque&in=duis&hac=bibendum&habitasse=morbi&platea=non&dictumst=quam&etiam=nec&faucibus=dui&cursus=luctus&urna=rutrum&ut=nulla&tellus=tellus&nulla=in&ut=sagittis&erat=dui&id=vel&mauris=nisl&vulputate=duis&elementum=ac&nullam=nibh&varius=fusce&nulla=lacus",
                Phone = "340-627-3401",
                Avalible = false
            }, new Driver
            {
                Id = "e972b2ed-1160-484f-8ab6-41ae9a78424f",
                Name = "Clevie Brimblecombe",
                Photo = "https=//bloomberg.com/pellentesque/at/nulla/suspendisse/potenti/cras/in.xml?velit=sem&vivamus=sed&vel=sagittis&nulla=nam&eget=congue",
                Phone = "103-926-0717",
                Avalible = true
            }, new Driver
            {
                Id = "e91593b7-7d6a-43bb-989c-df2421848589",
                Name = "George Duchan",
                Photo = "http=//hc360.com/dui/proin/leo/odio/porttitor/id.aspx?sapien=vitae&non=ipsum&mi=aliquam&integer=non&ac=mauris&neque=morbi&duis=non&bibendum=lectus&morbi=aliquam&non=sit&quam=amet&nec=diam&dui=in&luctus=magna&rutrum=bibendum&nulla=imperdiet&tellus=nullam&in=orci&sagittis=pede&dui=venenatis&vel=non&nisl=sodales&duis=sed&ac=tincidunt",
                Phone = "609-295-5064",
                Avalible = false
            }, new Driver
            {
                Id = "c89f1b6f-6938-4a88-adf7-d0c5ddba6a40",
                Name = "Harald Terram",
                Photo = "https=//is.gd/sit/amet/consectetuer/adipiscing/elit/proin/interdum.js?elementum=amet&ligula=consectetuer&vehicula=adipiscing&consequat=elit&morbi=proin&a=interdum&ipsum=mauris&integer=non&a=ligula&nibh=pellentesque&in=ultrices&quis=phasellus&justo=id&maecenas=sapien&rhoncus=in&aliquam=sapien&lacus=iaculis&morbi=congue&quis=vivamus&tortor=metus&id=arcu&nulla=adipiscing&ultrices=molestie&aliquet=hendrerit&maecenas=at&leo=vulputate&odio=vitae&condimentum=nisl&id=aenean&luctus=lectus&nec=pellentesque&molestie=eget&sed=nunc&justo=donec&pellentesque=quis&viverra=orci&pede=eget&ac=orci&diam=vehicula&cras=condimentum&pellentesque=curabitur&volutpat=in&dui=libero&maecenas=ut&tristique=massa&est=volutpat&et=convallis&tempus=morbi&semper=odio&est=odio&quam=elementum&pharetra=eu&magna=interdum&ac=eu&consequat=tincidunt&metus=in&sapien=leo&ut=maecenas&nunc=pulvinar&vestibulum=lobortis&ante=est&ipsum=phasellus&primis=sit&in=amet&faucibus=erat&orci=nulla&luctus=tempus&et=vivamus&ultrices=in&posuere=felis&cubilia=eu&curae=sapien&mauris=cursus&viverra=vestibulum&diam=proin&vitae=eu&quam=mi&suspendisse=nulla&potenti=ac&nullam=enim&porttitor=in&lacus=tempor&at=turpis&turpis=nec&donec=euismod&posuere=scelerisque&metus=quam&vitae=turpis&ipsum=adipiscing&aliquam=lorem&non=vitae&mauris=mattis&morbi=nibh&non=ligula&lectus=nec&aliquam=sem&sit=duis&amet=aliquam&diam=convallis",
                Phone = "209-900-8784",
                Avalible = false
            }, new Driver
            {
                Id = "dc55dfd2-cb38-41da-bec6-b073dcee8650",
                Name = "Mareah Carren",
                Photo = "https=//loc.gov/ut/volutpat/sapien/arcu/sed.jpg?consequat=pellentesque&morbi=viverra&a=pede&ipsum=ac&integer=diam&a=cras&nibh=pellentesque&in=volutpat&quis=dui&justo=maecenas&maecenas=tristique&rhoncus=est&aliquam=et&lacus=tempus&morbi=semper&quis=est&tortor=quam&id=pharetra&nulla=magna&ultrices=ac&aliquet=consequat&maecenas=metus&leo=sapien&odio=ut&condimentum=nunc&id=vestibulum&luctus=ante&nec=ipsum&molestie=primis&sed=in&justo=faucibus&pellentesque=orci&viverra=luctus&pede=et&ac=ultrices&diam=posuere&cras=cubilia&pellentesque=curae&volutpat=mauris&dui=viverra&maecenas=diam&tristique=vitae&est=quam&et=suspendisse",
                Phone = "344-987-2663",
                Avalible = false
            }, new Driver
            {
                Id = "76440f39-2ce6-4ef8-bf2f-0897314a0859",
                Name = "Jone Kures",
                Photo = "http=//eepurl.com/porta/volutpat/erat/quisque/erat/eros/viverra.json?ac=mauris&nibh=eget&fusce=massa&lacus=tempor&purus=convallis&aliquet=nulla&at=neque&feugiat=libero&non=convallis&pretium=eget&quis=eleifend&lectus=luctus&suspendisse=ultricies&potenti=eu&in=nibh&eleifend=quisque&quam=id&a=justo&odio=sit&in=amet&hac=sapien&habitasse=dignissim&platea=vestibulum&dictumst=vestibulum&maecenas=ante&ut=ipsum&massa=primis&quis=in&augue=faucibus&luctus=orci&tincidunt=luctus&nulla=et&mollis=ultrices&molestie=posuere&lorem=cubilia&quisque=curae&ut=nulla&erat=dapibus&curabitur=dolor&gravida=vel&nisi=est&at=donec&nibh=odio&in=justo&hac=sollicitudin&habitasse=ut&platea=suscipit&dictumst=a&aliquam=feugiat&augue=et&quam=eros&sollicitudin=vestibulum&vitae=ac&consectetuer=est&eget=lacinia&rutrum=nisi&at=venenatis&lorem=tristique&integer=fusce&tincidunt=congue&ante=diam&vel=id&ipsum=ornare&praesent=imperdiet&blandit=sapien&lacinia=urna&erat=pretium&vestibulum=nisl&sed=ut&magna=volutpat&at=sapien&nunc=arcu&commodo=sed&placerat=augue",
                Phone = "879-764-4669",
                Avalible = false
            }, new Driver
            {
                Id = "97ae9ed6-943f-4cd6-bb22-5c5549fddee1",
                Name = "Guthrey Rubertelli",
                Photo = "http=//bandcamp.com/vel.js?vel=in&accumsan=purus&tellus=eu&nisi=magna&eu=vulputate&orci=luctus&mauris=cum&lacinia=sociis&sapien=natoque&quis=penatibus&libero=et&nullam=magnis&sit=dis&amet=parturient&turpis=montes&elementum=nascetur&ligula=ridiculus&vehicula=mus&consequat=vivamus&morbi=vestibulum&a=sagittis&ipsum=sapien&integer=cum&a=sociis&nibh=natoque&in=penatibus&quis=et&justo=magnis&maecenas=dis&rhoncus=parturient&aliquam=montes&lacus=nascetur&morbi=ridiculus&quis=mus&tortor=etiam&id=vel&nulla=augue&ultrices=vestibulum&aliquet=rutrum&maecenas=rutrum&leo=neque&odio=aenean&condimentum=auctor&id=gravida&luctus=sem&nec=praesent&molestie=id&sed=massa&justo=id&pellentesque=nisl&viverra=venenatis&pede=lacinia&ac=aenean&diam=sit&cras=amet&pellentesque=justo&volutpat=morbi&dui=ut&maecenas=odio&tristique=cras&est=mi&et=pede&tempus=malesuada&semper=in&est=imperdiet&quam=et&pharetra=commodo&magna=vulputate&ac=justo&consequat=in&metus=blandit&sapien=ultrices&ut=enim&nunc=lorem&vestibulum=ipsum&ante=dolor&ipsum=sit&primis=amet&in=consectetuer&faucibus=adipiscing&orci=elit&luctus=proin&et=interdum&ultrices=mauris&posuere=non&cubilia=ligula&curae=pellentesque&mauris=ultrices&viverra=phasellus&diam=id&vitae=sapien&quam=in&suspendisse=sapien&potenti=iaculis&nullam=congue&porttitor=vivamus&lacus=metus&at=arcu&turpis=adipiscing&donec=molestie",
                Phone = "123-632-4879",
                Avalible = false
            }, new Driver
            {
                Id = "91402521-17ed-4d34-8264-13098a07e477",
                Name = "Alla Baum",
                Photo = "http=//pinterest.com/suspendisse/potenti/in/eleifend/quam/a.html?pretium=molestie&quis=nibh&lectus=in&suspendisse=lectus&potenti=pellentesque&in=at&eleifend=nulla&quam=suspendisse&a=potenti&odio=cras&in=in&hac=purus&habitasse=eu&platea=magna&dictumst=vulputate&maecenas=luctus&ut=cum&massa=sociis&quis=natoque&augue=penatibus&luctus=et&tincidunt=magnis&nulla=dis&mollis=parturient&molestie=montes&lorem=nascetur&quisque=ridiculus&ut=mus&erat=vivamus&curabitur=vestibulum&gravida=sagittis&nisi=sapien&at=cum&nibh=sociis&in=natoque&hac=penatibus&habitasse=et&platea=magnis&dictumst=dis&aliquam=parturient&augue=montes&quam=nascetur&sollicitudin=ridiculus&vitae=mus&consectetuer=etiam&eget=vel&rutrum=augue&at=vestibulum&lorem=rutrum&integer=rutrum&tincidunt=neque&ante=aenean&vel=auctor&ipsum=gravida&praesent=sem&blandit=praesent&lacinia=id&erat=massa&vestibulum=id&sed=nisl&magna=venenatis&at=lacinia&nunc=aenean&commodo=sit&placerat=amet&praesent=justo&blandit=morbi&nam=ut&nulla=odio&integer=cras&pede=mi&justo=pede&lacinia=malesuada&eget=in&tincidunt=imperdiet",
                Phone = "607-838-2127",
                Avalible = false
            }, new Driver
            {
                Id = "be08d0a3-6f94-4eab-8f9b-f46a1d809563",
                Name = "Merna Skipsea",
                Photo = "https=//themeforest.net/amet/eleifend.aspx?vel=felis&enim=sed&sit=interdum&amet=venenatis&nunc=turpis&viverra=enim&dapibus=blandit&nulla=mi&suscipit=in&ligula=porttitor&in=pede&lacus=justo&curabitur=eu&at=massa&ipsum=donec&ac=dapibus&tellus=duis&semper=at&interdum=velit&mauris=eu&ullamcorper=est",
                Phone = "553-690-2547",
                Avalible = false
            }, new Driver
            {
                Id = "fce15be2-b384-4bb0-af76-5938425caf09",
                Name = "Veriee Housen",
                Photo = "http=//blinklist.com/ipsum/aliquam/non/mauris/morbi.js?lobortis=sodales&convallis=sed&tortor=tincidunt&risus=eu&dapibus=felis&augue=fusce&vel=posuere&accumsan=felis&tellus=sed&nisi=lacus&eu=morbi&orci=sem&mauris=mauris&lacinia=laoreet&sapien=ut&quis=rhoncus&libero=aliquet&nullam=pulvinar&sit=sed&amet=nisl&turpis=nunc&elementum=rhoncus&ligula=dui&vehicula=vel&consequat=sem&morbi=sed&a=sagittis&ipsum=nam&integer=congue&a=risus&nibh=semper&in=porta&quis=volutpat&justo=quam&maecenas=pede&rhoncus=lobortis&aliquam=ligula&lacus=sit&morbi=amet&quis=eleifend&tortor=pede&id=libero&nulla=quis&ultrices=orci&aliquet=nullam&maecenas=molestie&leo=nibh&odio=in&condimentum=lectus&id=pellentesque&luctus=at&nec=nulla&molestie=suspendisse&sed=potenti&justo=cras&pellentesque=in&viverra=purus&pede=eu&ac=magna&diam=vulputate&cras=luctus&pellentesque=cum&volutpat=sociis&dui=natoque&maecenas=penatibus&tristique=et&est=magnis&et=dis&tempus=parturient&semper=montes&est=nascetur&quam=ridiculus&pharetra=mus&magna=vivamus&ac=vestibulum&consequat=sagittis&metus=sapien&sapien=cum&ut=sociis&nunc=natoque&vestibulum=penatibus&ante=et&ipsum=magnis&primis=dis&in=parturient&faucibus=montes&orci=nascetur",
                Phone = "486-110-3137",
                Avalible = false
            }, new Driver
            {
                Id = "1b68c1d3-7c24-4255-a11d-f3a44e8fa356",
                Name = "Lotty Dykes",
                Photo = "https=//dyndns.org/donec/vitae/nisi/nam/ultrices.jpg?aliquet=eget&maecenas=tempus&leo=vel&odio=pede&condimentum=morbi&id=porttitor&luctus=lorem&nec=id&molestie=ligula&sed=suspendisse&justo=ornare&pellentesque=consequat&viverra=lectus&pede=in&ac=est&diam=risus&cras=auctor&pellentesque=sed&volutpat=tristique&dui=in&maecenas=tempus&tristique=sit&est=amet&et=sem&tempus=fusce&semper=consequat&est=nulla&quam=nisl&pharetra=nunc&magna=nisl&ac=duis&consequat=bibendum&metus=felis&sapien=sed&ut=interdum&nunc=venenatis&vestibulum=turpis&ante=enim&ipsum=blandit&primis=mi&in=in&faucibus=porttitor&orci=pede",
                Phone = "445-564-5136",
                Avalible = false
            }, new Driver
            {
                Id = "299b17c5-e8b7-4d33-aafa-4a7f6a99e5b6",
                Name = "Clement Bourke",
                Photo = "https=//google.ca/hac/habitasse/platea.json?cras=hac&mi=habitasse&pede=platea&malesuada=dictumst&in=aliquam&imperdiet=augue&et=quam&commodo=sollicitudin&vulputate=vitae&justo=consectetuer&in=eget&blandit=rutrum&ultrices=at&enim=lorem&lorem=integer&ipsum=tincidunt&dolor=ante&sit=vel&amet=ipsum&consectetuer=praesent&adipiscing=blandit&elit=lacinia&proin=erat&interdum=vestibulum&mauris=sed&non=magna&ligula=at&pellentesque=nunc&ultrices=commodo&phasellus=placerat&id=praesent&sapien=blandit&in=nam&sapien=nulla&iaculis=integer&congue=pede&vivamus=justo&metus=lacinia&arcu=eget&adipiscing=tincidunt&molestie=eget&hendrerit=tempus&at=vel&vulputate=pede&vitae=morbi&nisl=porttitor&aenean=lorem&lectus=id&pellentesque=ligula&eget=suspendisse&nunc=ornare&donec=consequat&quis=lectus&orci=in&eget=est&orci=risus&vehicula=auctor&condimentum=sed&curabitur=tristique&in=in&libero=tempus&ut=sit&massa=amet&volutpat=sem",
                Phone = "816-639-3600",
                Avalible = false
            }, new Driver
            {
                Id = "6166fd69-b229-49df-9fed-3d6d11af1b3b",
                Name = "Arabele Newey",
                Photo = "http=//deliciousdays.com/odio/odio/elementum/eu/interdum/eu.xml?diam=vel&nam=nulla&tristique=eget&tortor=eros",
                Phone = "473-399-2256",
                Avalible = true
            }, new Driver
            {
                Id = "6fd68e9e-de81-4811-b856-7e27e5bee941",
                Name = "Gabbie Sprull",
                Photo = "http=//wikipedia.org/dapibus/nulla/suscipit/ligula/in/lacus/curabitur.jpg?in=nullam&hac=molestie&habitasse=nibh&platea=in&dictumst=lectus&morbi=pellentesque&vestibulum=at&velit=nulla&id=suspendisse&pretium=potenti&iaculis=cras&diam=in&erat=purus&fermentum=eu&justo=magna&nec=vulputate&condimentum=luctus&neque=cum&sapien=sociis&placerat=natoque&ante=penatibus&nulla=et&justo=magnis&aliquam=dis&quis=parturient&turpis=montes&eget=nascetur&elit=ridiculus&sodales=mus&scelerisque=vivamus&mauris=vestibulum&sit=sagittis&amet=sapien&eros=cum&suspendisse=sociis&accumsan=natoque&tortor=penatibus&quis=et&turpis=magnis&sed=dis&ante=parturient&vivamus=montes&tortor=nascetur&duis=ridiculus&mattis=mus&egestas=etiam&metus=vel&aenean=augue&fermentum=vestibulum&donec=rutrum&ut=rutrum&mauris=neque&eget=aenean&massa=auctor&tempor=gravida&convallis=sem&nulla=praesent&neque=id&libero=massa",
                Phone = "561-333-4069",
                Avalible = true
            }, new Driver
            {
                Id = "217498d7-036f-4914-9a63-af4d375accd8",
                Name = "Verene Linck",
                Photo = "https=//nps.gov/mollis/molestie/lorem/quisque.js?maecenas=dictumst&tincidunt=etiam&lacus=faucibus",
                Phone = "904-616-2490",
                Avalible = false
            }, new Driver
            {
                Id = "cfb79288-30ac-425a-bc2a-723f055e23e3",
                Name = "Freida Valentin",
                Photo = "http=//trellian.com/velit/nec/nisi/vulputate/nonummy.jpg?ac=ac&neque=neque&duis=duis&bibendum=bibendum&morbi=morbi&non=non&quam=quam&nec=nec&dui=dui&luctus=luctus&rutrum=rutrum&nulla=nulla&tellus=tellus&in=in",
                Phone = "980-446-7880",
                Avalible = false
            }, new Driver
            {
                Id = "42454230-1a7b-4ec8-b5a1-90b79973e5a8",
                Name = "Alla Furse",
                Photo = "http=//army.mil/suspendisse/accumsan.html?pede=enim&justo=in&eu=tempor&massa=turpis&donec=nec&dapibus=euismod&duis=scelerisque&at=quam&velit=turpis&eu=adipiscing&est=lorem&congue=vitae&elementum=mattis&in=nibh&hac=ligula&habitasse=nec&platea=sem&dictumst=duis&morbi=aliquam&vestibulum=convallis&velit=nunc&id=proin&pretium=at&iaculis=turpis&diam=a&erat=pede&fermentum=posuere&justo=nonummy&nec=integer&condimentum=non&neque=velit&sapien=donec&placerat=diam&ante=neque&nulla=vestibulum&justo=eget&aliquam=vulputate&quis=ut&turpis=ultrices&eget=vel&elit=augue&sodales=vestibulum&scelerisque=ante&mauris=ipsum&sit=primis&amet=in&eros=faucibus&suspendisse=orci&accumsan=luctus&tortor=et&quis=ultrices&turpis=posuere&sed=cubilia&ante=curae",
                Phone = "123-580-3851",
                Avalible = false
            }, new Driver
            {
                Id = "6eaead16-849d-48be-8029-3be05c1971b3",
                Name = "Faber Lochran",
                Photo = "https=//meetup.com/amet/diam.jpg?a=mauris&feugiat=non&et=ligula",
                Phone = "936-126-3837",
                Avalible = false
            }, new Driver
            {
                Id = "55ea169b-8d9d-4760-8f59-d092a694975c",
                Name = "Amos Kubatsch",
                Photo = "http=//bizjournals.com/porta.aspx?felis=ut&sed=dolor&interdum=morbi&venenatis=vel&turpis=lectus&enim=in&blandit=quam&mi=fringilla&in=rhoncus&porttitor=mauris&pede=enim&justo=leo&eu=rhoncus&massa=sed&donec=vestibulum&dapibus=sit&duis=amet&at=cursus&velit=id&eu=turpis&est=integer&congue=aliquet&elementum=massa&in=id&hac=lobortis&habitasse=convallis&platea=tortor&dictumst=risus&morbi=dapibus&vestibulum=augue&velit=vel&id=accumsan&pretium=tellus&iaculis=nisi&diam=eu&erat=orci&fermentum=mauris&justo=lacinia&nec=sapien&condimentum=quis&neque=libero&sapien=nullam&placerat=sit&ante=amet&nulla=turpis&justo=elementum&aliquam=ligula&quis=vehicula&turpis=consequat&eget=morbi&elit=a&sodales=ipsum&scelerisque=integer&mauris=a&sit=nibh&amet=in&eros=quis&suspendisse=justo&accumsan=maecenas&tortor=rhoncus&quis=aliquam&turpis=lacus",
                Phone = "724-637-4801",
                Avalible = true
            }, new Driver
            {
                Id = "c5c9dbdb-fa9d-4f63-8d85-cdb5bb04b967",
                Name = "Baudoin Dackombe",
                Photo = "https=//usatoday.com/ac/neque/duis/bibendum/morbi/non.jsp?felis=felis&fusce=eu&posuere=sapien&felis=cursus&sed=vestibulum&lacus=proin&morbi=eu",
                Phone = "248-272-5791",
                Avalible = true
            }, new Driver
            {
                Id = "3a4a4b8f-98e5-401f-b007-252550c43f8b",
                Name = "Salome Braxton",
                Photo = "https=//umich.edu/eget/rutrum/at.html?lobortis=faucibus&convallis=orci&tortor=luctus&risus=et&dapibus=ultrices&augue=posuere&vel=cubilia&accumsan=curae&tellus=nulla&nisi=dapibus&eu=dolor&orci=vel&mauris=est&lacinia=donec&sapien=odio&quis=justo&libero=sollicitudin&nullam=ut&sit=suscipit&amet=a&turpis=feugiat&elementum=et&ligula=eros&vehicula=vestibulum&consequat=ac&morbi=est&a=lacinia&ipsum=nisi&integer=venenatis&a=tristique&nibh=fusce&in=congue&quis=diam&justo=id&maecenas=ornare&rhoncus=imperdiet",
                Phone = "618-898-0689",
                Avalible = false
            }, new Driver
            {
                Id = "cef0df6f-032a-4dcf-bca2-fff165ca016e",
                Name = "Albrecht Wheatcroft",
                Photo = "https=//phoca.cz/sapien/cursus/vestibulum/proin/eu/mi.jpg?nec=ut&sem=at&duis=dolor&aliquam=quis&convallis=odio&nunc=consequat&proin=varius&at=integer&turpis=ac&a=leo&pede=pellentesque&posuere=ultrices&nonummy=mattis&integer=odio&non=donec&velit=vitae&donec=nisi&diam=nam&neque=ultrices&vestibulum=libero&eget=non&vulputate=mattis&ut=pulvinar&ultrices=nulla&vel=pede&augue=ullamcorper&vestibulum=augue&ante=a&ipsum=suscipit&primis=nulla&in=elit&faucibus=ac&orci=nulla&luctus=sed&et=vel&ultrices=enim&posuere=sit&cubilia=amet&curae=nunc&donec=viverra&pharetra=dapibus&magna=nulla&vestibulum=suscipit&aliquet=ligula&ultrices=in&erat=lacus&tortor=curabitur&sollicitudin=at&mi=ipsum&sit=ac&amet=tellus&lobortis=semper&sapien=interdum&sapien=mauris&non=ullamcorper&mi=purus&integer=sit&ac=amet&neque=nulla&duis=quisque&bibendum=arcu&morbi=libero&non=rutrum&quam=ac&nec=lobortis",
                Phone = "311-916-9654",
                Avalible = true
            }};


        public List<Driver> GetAllDrivers()
        {

            return drivers;
        }
    }

}
