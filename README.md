Enhanced Steam Standalone
=============

Enhanced Steam Standalone, a standalone version of the [Enhanced Steam](https://github.com/jshackles/Enhanced_Steam) plugin for various browsers (Chrome*, Firefox, Opera), that works with any html-css-and-js-aware http client (including the Steam client).

This repository
---------------

This repository is a fork of the main github repository,
which is located [here](https://github.com/jshackles/Enhanced_Steam_Standalone).

The fork was made to attempt to add Linux support.

Running on Windows
------------

For now, the installation requires several steps, with a lot of manual work:

1. Clone this repository.
2. Start "start-stop.bat" as Administrator ([it can be automatic](http://stackoverflow.com/questions/6811372/how-to-code-a-bat-file-to-always-run-as-admin-mode#answer-13811519); and you can also set the correct ES icon).
4. Browse Steam with new features.

OR

1. Clone this repository.
2. Edit your [hosts](https://en.wikipedia.org/wiki/Hosts_%28file%29#Location_in_the_file_system) file to resolve store.steampowered.com and steamcommunity.com locally (use two different IPs, like 127.0.0.200 and 127.0.0.201; as it is needed for HTTPS). You can also append the [hosts](hosts) file from this repository to yours.
3. Launch Enhanced Steam.exe
4. Browse Steam with new features.

_Note: If you modify the local IP addresses in the hosts file, please modify them in the rinetd\rinetd.conf file also._


Running on Linux
------------

These instructions have been tested on Ubuntu 14.04,
but the script (stop-start-bash.sh) should work on any Unix
based system, including Mac OSX.
On systems that don't use apt-get for installation
you'll have to work out the installation of nginx and
rinetd yourself.

1. Clone this repository.

2. If nginx and rinetd aren't installed already,
   so. On Debian based systems (Debian, Ubuntu,
   Linux Mint etc.) open a terminal and use this command:

       sudo apt-get install nginx rinetd

3. In a terminal window cd to the folder that you
   cloned this repository into.
   E.g, assuming you cloned it into your home
   directory:
       cd ~/Enhanced_Steam_Standalone

   Now type:
       chmod +x start-stop-bash.sh

   And press Enter

4. Finally type
       sudo ./start-stop-bash.sh

   to start Enhanced Steam working.
   Note that sudo is required, because the script
   edits you /etc/hosts file. The next time you run it
   it will put back the way it was.

5. To stop Enhanced Steam again, re-run the shell script.

Principle
---------

This project creates a local proxy that injects some javascript into the Steam store and community pages, so they will be enhanced.  Here is how it processes, step by step:

1. The DNS records for the store and the community are spoofed, thanks to the hosts file.
2. The browser then targets localhost for both domains.
3. On the local host, the nginx proxy server is running, and therefore, ready to proxy the Steam store and community.
4. On that same local host, rinetd is running and ready to proxy any other TCP streams that would be needed (such as HTTPS).
5. When connected to the proxi-ed steam pages, the nginx daemon queries the DNS (a real one, not the hosts file), to get the IP addresses of the called domain. Then it forwards the request.
6. When the page is returned, it perfoms the code injection, and serves the content to the client.

What else you can do
--------------------

With that principle in mind, and using this software, you can do the following things:

- Use Enhanced Steam with _any_ browser you want, transparently.
- Serve Enhanced Steam for a whole network (a LAN for example)

FixMe
-----
- [IMPORTANT] The nginx sub_filter can only work with uncompressed streams, and that can be problematic, since it will cause an important waste of bandwith for Steam/Valve if this software is used too broadly.
- [TRIVIAL] The current link in the error page (50x.html) always redirects to the test for the store. It should depend on the host.

License
-----
This project uses open source code from [nginx](http://nginx.org/LICENSE), [rinetd](http://www.boutell.com/rinetd/), and [Enhanced Steam](https://github.com/jshackles/Enhanced_Steam), and their contributors.

Todo
----
- The TCP proxy uses IP addresses for the redirection. It would be better to use domains instead (eg. store.steampowered.com and steamcommunity.com)
- Improve the content of the error page, with better "is online" testing; and why not with js.
- Better launch application

Credit
------

Enhanced Steam Standalone is based on an idea (proxy/injection) and "implementation" of [7heo](https://github.com/7heo), and uses the Enhanced Steam javascript plugin from [jshackles](https://github.com/jshackles) and Enhanced Steam contributors. All this repository's content has been released under GPL v2, unless noted otherwise (for other software such as nginx and rinetd).
