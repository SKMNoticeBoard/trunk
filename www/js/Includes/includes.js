/**
 * Created by Mane on 23/04/2016.
 */
/*$().ready(function () {*/
/*});*/

var path = "js";
//Services
for (var i = 0; i < Files.services.length; i++) {
  console.log("Serv");
  console.log(['<script src="', path + Files.services[i], '"></script>'].join(''));
  var html = ['<script src="', path + Files.services[i], '"></script>'].join('');
  $('head').append($(html));
}

//Controllers

  for (var i = 0; i < includesConfig.controllers.length; i++) {
    var html = ['<script src="', path + includesConfig.controllers[i], '"></script>'].join('');
    $('head').append($(html));
  }


