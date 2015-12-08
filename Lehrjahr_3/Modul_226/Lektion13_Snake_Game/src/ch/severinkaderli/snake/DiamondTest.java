package ch.severinkaderli.snake;

import static org.junit.Assert.*;

import java.awt.Rectangle;

import org.junit.Before;
import org.junit.Test;

public class DiamondTest {

	private Diamond diamond;

	@Before
	public void setUp() {
		diamond = new Diamond(10, 10, 100, 100, 5);
	}

	@Test
	public void testDiamondObjectIsCreatedProperly() {
		assertEquals(new Rectangle(10, 10, 100, 100), diamond.position);
		assertEquals(5, diamond.value);
		assertTrue(diamond.isAlive);
	}

	@Test
	public void testDestroySetsAliveToFalse() {
		diamond.destroy();
		assertFalse(diamond.isAlive);
	}

	@Test
	public void testRevive() {
		diamond.revive();
		assertTrue(diamond.isAlive);
	}

}
