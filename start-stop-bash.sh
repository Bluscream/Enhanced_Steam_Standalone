#!/bin/bash
# ******************************************************
# * Enhanced Steam Standalone bash script.             *
# *                                                    *
# * Author: MageJohn github.com/magejohn               *
# * Date: 02/10/2014                                   *
# *                                                    *
# ******************************************************

# Make sure only root can run the script
if [[ $EUID -ne 0 ]]; then
   echo "This script must be run as root" 1>&2
   exit 1
fi

HOSTSFILE='/etc/hosts'
HOSTSBACKUP='/etc/hosts.bak'
DIR="$( cd "$( dirname "$0" )" && pwd )"
# DIR now contains the directory of this script

if [[ -f $HOSTSBACKUP ]]
then
        mv $HOSTSBACKUP $HOSTSFILE
        killall nginx
        killall rinetd
else
        cp $HOSTSFILE $HOSTSBACKUP
        echo '127.0.0.200 store.steampowered.com' >> $HOSTSFILE
        echo '127.0.0.201 steamcommunity.com' >> $HOSTSFILE
        nginx -p $DIR/ -c conf/nginx.conf
        rinetd -c $DIR/conf/rinetd.conf
fi
       

