//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Questions
//{
//    class Chess
//    {
//    }
//}
///*
// * /**
// * A chess piece on the game board.
// * A piece has a color (white or black), type (pawn, knight, bishop, rook, 
// * queen, or king), and a position on the game board at all times.  Once 
// * a piece is created, its position may change, but its color and type
// * will never change.
// * @author Marty Stepp
// * @version 1.0
// */
///*
//public class Piece {
//    // class constants
//    // Colors for pieces. 
//    public static final String BLACK = "Black";
//    public static final String WHITE = "White";

//    // Types for pieces. 
//    public static final String PAWN = "Pawn";
//    public static final String KNIGHT = "Knight";
//    public static final String BISHOP = "Bishop";
//    public static final String ROOK = "Rook";
//    public static final String QUEEN = "Queen";
//    public static final String KING = "King";

//    // fields
//    private String color;
//    private String type;
//    private int row;
//    private int column;

//    // constructors
//    /**
//     * Constructs a new chess piece of the given color and type, 
//     * at the given position.
//     * 
//     * @param color  The piece's color; must be BLACK or WHITE.
//     * @param type   The piece's type; must be PAWN, KNIGHT, BISHOP,
//     *										 ROOK, QUEEN, or KING.
//     * @param row	The piece's row position; must be a valid index.
//     * @param column The piece's column position; must be a valid index.
//     * 
//     * @throws IllegalArgumentException if the arguments are improper.
//     */
//    public Piece(String color, String type, int row, int column) {
//        if (!(color.equals(BLACK) || color.equals(WHITE)) 
//                || !(type.equals(KING) || type.equals(QUEEN)
//                || type.equals(BISHOP) || type.equals(KNIGHT) 
//                || type.equals(ROOK) || type.equals(PAWN)) ||
//                !Board.isOnBoard(row,column))
//        {
//            throw new IllegalArgumentException();
//        }
			
//        this.color  = color;
//        this.type   = type;
//        this.row	= row;
//        this.column = column;
		
//    }

//    // methods
//    /**
//     * Returns this chess piece's color. 
//     * @return the color; either BLACK or WHITE.
//     */
//    public String getColor() {
//        return this.color;
//    }

//    /**
//     * Returns this chess piece's type.
//     * @return the type; either PAWN, KNIGHT, BISHOP, ROOK, QUEEN, or KING.
//     */
//    public String getType() {
//        return this.type;
//    }

//    /**
//     * Returns this chess piece's row position.
//     * @return the position; must be in range [0, Board.SIZE).
//     */
//    public int getRow() {
//        return this.row;
//    }

//    /**
//     * Returns this chess piece's row position.
//     * @return the position; must be in range [0, Board.SIZE).
//     */
//    public int getColumn() {
//        return this.column;
//    }

//    /**
//     * Returns a String representation of this piece.
//     * @return a single-letter String, such as "Q" for a queen.
//     */
//    public String toString() {
//        return this.type.substring(0, 1);
//    }

//    /**
//     * Returns whether this piece can legally move to the given position, 
//     * assuming that the position is unoccupied.
//     *  
//     * @param row The row position to potentially move to.
//     * @param column The column position to potentially move to.
//     * @return true if the given position is legal to move to.
//     * 
//     * @throws IllegalArgumentException if the row or column are not a 
//     *								  valid chess board position (0--7).
//     * 
//     * TODO: write this
//     */
//    public boolean canMove(int row, int column) {
	    
//        if (!Board.isOnBoard(row, column))
//            return false;
	    
//        if (type == KNIGHT) {
//            return canKnightMove(row, column);
//        }
//        if (type == ROOK){
//            return canRookMove(row,column);
//        }
		
//        if(type== BISHOP){
//            return canBishopMove(row,column);
//        }
//        if(type== QUEEN){
//            return canQueenMove(row,column);
//        }
//        return false;
//    }
	
	
//    /**
//     * Determine if the Knight can move to the given space
//     * 
//     * @param row The row to check
//     * @param column The column to check
//     * @return Whether or not the Knight can move
//     */
//    public boolean canKnightMove(int row, int column) {
	    
//        int diffRow = Math.abs(row - this.row);
//        int diffCol = Math.abs(column - this.column);
	    
//        if ((diffRow == 2 && diffCol == 1) || (diffRow == 1 && diffCol == 2)) {
//            return true;
//        }
	    
//        return false;
//    }
	
//    public boolean canRookMove(int row, int column){
//        if (row == this.row || column==this.column)
//            return true;
//        return false;
//    }
	
//    public boolean canBishopMove(int row, int column){
	
//        int diffRow = Math.abs(row - this.row);
//        int diffCol = Math.abs(column - this.column);
	    
	    
//        if(diffRow == diffCol)
//            return true;
	    
	    
//        return false;
//    }
//    public boolean canQueenMove (int row, int column){
//        return (canRookMove(row,column)|| canBishopMove(row,column));
//    }

//    /**
//     * Returns whether this piece can legally move to and capture a 
//     * hypothetical opposing piece that is at the given position.
//     *  
//     * @param row The row position of the piece to capture.
//     * @param column The column position of the piece to capture.
//     * @return true if the given position is legal to capture.
//     * 
//     * @throws IllegalArgumentException if the row or column are not a 
//     *								  valid chess board position (0--7).
//     * 
//     * TODO: write this
//     */
//    public boolean canCapture(int row, int column) {
//        return false;
//    }

//    /**
//     * Moves this piece to the given position.
//     * 
//     * @param row The row position to potentially move to.
//     * @param column The column position to potentially move to.
//     * 
//     * @throws IllegalArgumentException if the row or column are not a 
//     *		 valid chess board position (0--7), or if this piece
//     *		 cannot legally move to the given position.
//     */
//    public void move(int row, int column) {
//        this.row	= row;
//        this.column = column;
//        if (!canMove(row, column)){
//            throw new IllegalArgumentException("Illegal move");
//        }

//      }
//}

///**
// * An 8x8 chess board.
// * 
// * @author Marty Stepp
// * @version 1.0 2005-02-09
// * 
// * TODO: finish this class
// */
//public class Board {
//    /** The size of the chess board in each dimension. */
//    public static final int SIZE = 8;
	
//    /**
//     * Returns whether the given index is on the chess board.
//     * This will be true if it is non-negative and less than SIZE.
//     * 
//     * @param index The index to check.
//     * @return 0 <= index && index < SIZE
//     */
//    public static boolean isOnBoard(int index) {
//        return 0 <= index && index < SIZE;
//    }
	
//    /**
//     * Returns whether the given position is on the chess board.
//     * This will be true if the row and column are both non-negative 
//     * and less than SIZE.
//     * 
//     * @param row    The row position to check.
//     * @param column The column position to check.
//     * @return true if both are on board.
//     */
//    public static boolean isOnBoard(int row, int column) {
//        return isOnBoard(row) && isOnBoard(column);
//    }
//}

///*
// * Created on Feb 9, 2005
// *
// * TODO To change the template for this generated file go to
// * Window - Preferences - Java - Code Style - Code Templates
// */

///**
// * @author stepp
// *
// * TODO To change the template for this generated type comment go to
// * Window - Preferences - Java - Code Style - Code Templates
// */
//public class GUI {

//}

///*
// * Created on Feb 9, 2005
// *
// * TODO To change the template for this generated file go to
// * Window - Preferences - Java - Code Style - Code Templates
// */

///**
// * @author stepp
// *
// * TODO To change the template for this generated type comment go to
// * Window - Preferences - Java - Code Style - Code Templates
// */
//public class Player {

//}

//import junit.framework.TestCase;

///**
// * Tests the Piece class's canMove and canCapture methods.
// * 
// * @author Marty Stepp
// * @version 1.0 2005-02-09
// */
//public class PieceTester extends TestCase {
//    /**
//     * Runs the program.
//     * 
//     * @param args not used
//     */
//    public void testCanMove() {
//        assertEquals(
//            "\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ P _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            "\n",
//            boardTest(new Piece(Piece.BLACK, Piece.PAWN, 2, 6)));

//        assertEquals(
//            "\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ P _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            "\n",
//            boardTest(new Piece(Piece.WHITE, Piece.PAWN, 6, 3)));

//        assertEquals(
//            "\n" +
//            " _ _ _ _ _ . _ .\n" +
//            " _ _ _ _ . _ _ _\n" +
//            " _ _ _ _ _ _ K _\n" +
//            " _ _ _ _ . _ _ _\n" +
//            " _ _ _ _ _ . _ .\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            "\n",
//            boardTest(new Piece(Piece.BLACK, Piece.KNIGHT, 2, 6)));

//        assertEquals(
//            "\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ .\n" +
//            " . _ _ _ _ _ . _\n" +
//            " _ . _ _ _ . _ _\n" +
//            " _ _ . _ . _ _ _\n" +
//            " _ _ _ B _ _ _ _\n" +
//            " _ _ . _ . _ _ _\n" +
//            "\n",
//            boardTest(new Piece(Piece.WHITE, Piece.BISHOP, 6, 3)));
//        assertEquals(
//            "\n" +
//            " _ _ _ _ _ . _ _\n" +
//            " _ _ _ _ _ . _ _\n" +
//            " _ _ _ _ _ . _ _\n" +
//            " . . . . . R . .\n" +
//            " _ _ _ _ _ . _ _\n" +
//            " _ _ _ _ _ . _ _\n" +
//            " _ _ _ _ _ . _ _\n" +
//            " _ _ _ _ _ . _ _\n" +
//            "\n",
//            boardTest(new Piece(Piece.BLACK, Piece.ROOK, 3, 5)));

//        assertEquals(
//            "\n" +
//            " _ _ . _ . _ . _\n" +
//            " _ _ _ . . . _ _\n" +
//            " . . . . Q . . .\n" +
//            " _ _ _ . . . _ _\n" +
//            " _ _ . _ . _ . _\n" +
//            " _ . _ _ . _ _ .\n" +
//            " . _ _ _ . _ _ _\n" +
//            " _ _ _ _ . _ _ _\n" +
//            "\n",
//            boardTest(new Piece(Piece.BLACK, Piece.QUEEN, 2, 4)));

//        assertEquals(
//            "\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            " _ _ _ _ _ K _ _\n" +
//            " _ _ _ _ _ _ _ _\n" +
//            "\n",
//            boardTest(new Piece(Piece.WHITE, Piece.KING, 6, 5)));
//    }
	
//    // Prints the board state and which squares the given piece can
//    // move to / capture.
//    private static String boardTest(Piece p) {
//        try {
//            String result = "\n";
//            for (int row = 0; row < Board.SIZE; row++) {
//                for (int col = 0; col < Board.SIZE; col++) {
//                    result += " ";
//                    if (row == p.getRow() && col == p.getColumn())
//                        result += p;
//                    else if (p.canCapture(row, col))
//                        result += "x";
//                    else if (p.canMove(row, col))
//                        result += ".";
//                    else
//                        result += "_";
//                }

//                result += "\n";
//            }

//            result += "\n";
//            return result;
//        } catch (Exception e) {
//            return e.getClass().getName();
//        }
//    }
//}

//*/
