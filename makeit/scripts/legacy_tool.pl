#!/usr/bin/perl
# Very simple perl script often found in legacy repos
use strict;
use warnings;
my $file = shift || 'data.txt';
open my $fh, '<', $file or die "Can't open $file: $!";
while(<$fh>){
    print "LINE: $_";
}
close $fh;
