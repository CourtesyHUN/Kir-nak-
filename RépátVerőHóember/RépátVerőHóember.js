var p = 0;
var repak = [];
var repadb = 3;
var pont = 0;
var hp = 5;
var szint = 1;
var szintnovelhang = new Audio("levelup.wav");
var leesikhang = new Audio("leesik.wav");
var elkapta = new Audio("elkap.wav");
var lose = new Audio("lose.wav");
var dinamithang = new Audio("dinamit.wav")

RepaGen();

function RepaGen() {
  for (let i = 0; i < repadb; i++) {
    var repa = {
      x: Math.floor(Math.random() * 850),
      y: Math.floor(Math.random() * 100) - 100,
      s: Math.floor(Math.random() * 40) + 10,
      speed: Math.floor(Math.random() * 3) + 1,
      kep: "repa.gif",
    };
    repak.push(repa);
  }
  for (var i = 0; i < repadb; i++) {
    document.getElementById("content").innerHTML +=
      "<img src='repa.gif' class='repakep' id='repa_" +
      i +
      "' style='width: " +
      repak[i].s +
      "px'>";
  }
  RepaRajz();
  setInterval(RepaMozgat, 20);
}

function RepaRajz() {
  for (var i = 0; i < repadb; i++) 
  {
    document.getElementById("repa_" + i).style.top = repak[i].y + "px";
    document.getElementById("repa_" + i).style.left = repak[i].x + "px";
  }
}

function HpLevesz(x) {
  hp--;
  document.getElementById("elet").innerHTML = "";
  for (let i = 0; i < hp; i++) {
    document.getElementById("elet").innerHTML += "❤";
  }
  if (x == "repa") 
  {
    lose.play()  
  }
  else if (x == "dinamit") 
  {
    dinamithang.play()  
  }

  leesikhang.play();
  if (hp == 0) {
    lose.play();
    alert("Game Over - Score :" + pont);
    location.reload();
  }
}

function RepaMozgat() {
  for (var i = 0; i < repadb; i++) {   
    repak[i].y += repak[i].speed;
    if (repak[i].y > 500+repak[i].s) 
    {
      //Fel kell tenni a kép tetejére
      if (repak[i].kep == "repa.gif") HpLevesz();
      repak[i].x = Math.floor(Math.random() * 850);
      repak[i].y = Math.floor(Math.random() * 100) - 100;
      var vel = Math.floor(Math.random()*10)
      if (vel == 0) 
      {
        repak[i].kep = "dinamit.gif"  
      }
      else
      {
        repak[i].kep = "repa.gif"
      }
      document.getElementById("repa_" + i).src = repak[i].kep;
    }
  }
  // Elkapta-e valamelyiket a hóember
  for (let i = 0; i < repadb; i++) {
    if (repak[i].x >= p && repak[i].x <= p + 150 && repak[i].y > 600 - 150 - repak[i].s * 2)
    {
      if (repak[i].kep == "repa.gif") 
      {
        PontNovel(repak[i].speed)  
      }
      else if(repak[i].kep == "dinamit.gif")
      {
        HpLevesz("dinamit")
      } 
      repak[i].x = Math.floor(Math.random() * 850);
      repak[i].y = Math.floor(Math.random() * 100) - 100;
      var vel = Math.floor(Math.random()*10)
      if (vel == 0) 
      {
        repak[i].kep = "dinamit.gif"  
      }
      else
      {
        repak[i].kep = "repa.gif"
      }
      document.getElementById("repa_" + i).src = repak[i].kep;
    }
  }
  RepaRajz();
}

function PontNovel(x) {
  pont += x;
  document.getElementById("pontszam").innerHTML = pont;
  var cookie = (document.cookie = "Előző elért pont: " + pont);
  if (pont > 50 && szint == 1) {
    SzintNovel();
    document.getElementById("szint").innerHTML = "Lvl: " + szint;
    console.log(szint);
  }
  if (pont > 250 && szint == 2) {
    SzintNovel();
    document.getElementById("szint").innerHTML = "Lvl: " + szint;
  }
  if (pont > 500 && szint == 3) {
    SzintNovel();
    document.getElementById("szint").innerHTML = "Lvl: " + szint;
  }
  if (pont > 750 && szint == 4) {
    SzintNovel();
    document.getElementById("szint").innerHTML = "Lvl: " + szint;
  }
  if (pont > 1000 && szint == 5) {
    SzintNovel();
    document.getElementById("szint").innerHTML = "Lvl: " + szint;
  }
  if (pont > 1250 && szint == 6) {
    SzintNovel();
    document.getElementById("szint").innerHTML = "Lvl: " + szint;
  }
  if (pont > 1500 && szint == 7) {
    SzintNovel();
    document.getElementById("szint").innerHTML = "Lvl: " + szint;
  }
  if (pont > 1750 && szint == 8) {
    SzintNovel();
    document.getElementById("szint").innerHTML = "Lvl: " + szint;
  }
  if (pont > 200 && szint == 9) {
    SzintNovel();
    document.getElementById("szint").innerHTML = "Lvl: " + szint;
  }
  elkapta.play();
}

function SzintNovel() {
  szint++;
  repadb++;
  var repa = {
    x: Math.floor(Math.random() * 1000),
    y: Math.floor(Math.random() * 100) - 100,
    s: Math.floor(Math.random() * 40) + 10,
    speed: Math.floor(Math.random() * 5) + 1,
    kep: "repa.gif"
  };
  repak.push(repa);
  i = repadb - 1;
  document.getElementById("content").innerHTML +=
    "<img src='repa.gif' class='repakep' id='repa_" +
    i +
    "' style='width: " +
    repak[i].s +
    "px'>";
  szintnovelhang.play();
}

function Hely(x) {
  document.getElementById("hoember").style.left = x + "px";
}

var tickRate = 30,
  keyDown = {},
  keyMap = {
    37: "left",
    38: "up",
    39: "right",
    40: "down",
  };

$("body").keydown(function (e) {
  keyDown[keyMap[e.which]] = true;
});
$("body").keyup(function (e) {
  keyDown[keyMap[e.which]] = false;
});

var tick = function () {
  if (keyDown["up"]) {
    // up code
  } else if (keyDown["down"]) {
    // down code
  } else if (keyDown["left"]) {
    if (p > 0) {
      p -= 15;
      // left code
    }
  } else if (keyDown["right"]) {
    if (p < 740) {
      p += 15;
      // right code
    }
  }
  // other code
  Hely(p);
  setTimeout(tick, tickRate);
};

tick();
